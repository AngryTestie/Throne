﻿using System;
using System.Net;
using System.Net.Sockets;
using Throne.Framework;
using Throne.Framework.Exceptions;
using Throne.Framework.Logging;
using Throne.Framework.Network.Communication;
using Throne.Framework.Network.Connectivity;
using Throne.Framework.Network.Handling;
using Throne.Framework.Network.Security;
using Throne.Login.Accounts;
using TcpClient = Throne.Framework.Network.Communication.TcpClient;

namespace Throne.Login.Network
{
    public sealed class LoginClient : TcpClient, IClient
    {
        private const Int32 MIN_MSG_SIZE = 4;
        private const Int32 MAX_MSG_SIZE = 1016;
        private const Int32 MAX_STREAM_SIZE = UInt16.MaxValue;

        private readonly Logger _log = new Logger("AuthClient");


        private readonly Int32 _minStreamSize;

        private readonly IPacketPropagator _propagator;

        public LoginClient(ConnectionEventArgs args)
            : base(args)
        {
            _minStreamSize = TcpServer.IncomingFooterLength + MIN_MSG_SIZE;
            _propagator = args.PacketPropagator;
            StreamCipher = args.StreamCipher;

            Log.Info("{0} connected", ClientAddress);
        }

        public override void Send(byte[] value)
        {
            if (Connected)
            {
                SocketAsyncEventArgs sndSocketArgs = SocketAsyncEventArgsPool.Acquire(IOComplete);

                if (StreamCipher != null)
                    value = StreamCipher.Encrypt(value, value.Length);

                sndSocketArgs.SetBuffer(value, 0, value.Length);

                try
                {
                    if (!Socket.SendAsync(sndSocketArgs))
                        OnSend(sndSocketArgs);
                }
                catch (Exception ex)
                {
                    Disconnect();

                    if (ex is ObjectDisposedException)
                        return;

                    ExceptionManager.RegisterException(ex);
                }
            }
            else if (!Disconnected) Disconnect();
        }

        public IPAddress ClientAddress
        {
            get { return ((IPEndPoint) Socket.RemoteEndPoint).Address; }
        }

        public void DisconnectWithMessage(Byte[] message)
        {
            throw new NotImplementedException();
        }

        public INetworkCipher StreamCipher { get; private set; }

        public INetworkCipher TransferCipher { get; set; }

        public Logger Log
        {
            get { return _log; }
        }

        public void Respond(string response)
        {
            throw new NotImplementedException();
        }

        public void Respond(byte[] response)
        {
            Send(response);
        }

        protected override unsafe void OnReceive()
        {
            if (BytesTransferred >= _minStreamSize)
            {
                byte[] decipheredBuffer = StreamCipher.Decrypt(rcvBuffer, BytesTransferred);
                var position = new Int32();

                while (position < BytesTransferred && !Disconnected)
                    fixed (Byte* src = decipheredBuffer)
                    {
                        byte* srcP = src + position;
                        short msgSize = *(Int16*) srcP;
                        short msgType = *(Int16*) (srcP + 2);

                        if (!msgSize.IsBetween<Int16>(MIN_MSG_SIZE, MAX_MSG_SIZE))
                            break;

                        var msg = new Byte[msgSize];

                        fixed (Byte* dst = msg)
                            for (byte* dstP = dst;
                                msgSize-- > 0 && position < BytesTransferred;
                                position++)
                                *dstP++ = *srcP++;

                        _propagator.Handle(this, msgType, msg, (Int16) msg.Length);
                    }
            }

            if (BytesTransferred < _minStreamSize)
            {
                Log.Error("Connection dropped because of empty stream. {0}", ClientAddress);
                Disconnect();
            }
            else
                Receive();
        }
    }
}