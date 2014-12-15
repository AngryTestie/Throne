﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Throne.Shared;
using Throne.Shared.Collections;
using Throne.Shared.Logging;
using Throne.Shared.Network.Transmission.Stream;
using Throne.Shared.Runtime;
using Throne.World.Network;
using Throne.World.Network.Messages;
using Throne.World.Properties.Settings;
using Throne.World.Records;
using Throne.World.Structures.Storage;
using Throne.World.Structures.Travel;
using Constants = Throne.World.Properties.Constants;

namespace Throne.World.Structures.Objects
{
    /// <summary> An in-game user controlled entity with an archetype. </summary>
    public sealed partial class Character : Role, IDisposableResource
    {
        public Character(WorldClient user, CharacterRecord record)
            : base(record.Guid)
        {
            User = user;
            Record = record;

            User.Log = new LogProxy("{0}:{1}".Interpolate(Name, user.ClientAddress));

            _timers = new Dictionary<CharacterTask, CharacterTimer>();

            _look = new Model(Record.Look, Record.Hairstyle);
            _pStats = new BooleanArray<RoleState>(192);

            IEnumerable<Item> items = Record.ItemPayload.Select(itemRecord => new Item(itemRecord));
            {
                _gear = new Gear(items);
                _inventory = new Inventory(items);
            }

            (new Stream() +
             Constants.LoginMessages.ServerInfo +
             Constants.LoginMessages.AnswerOk +
             new CharacterInformation(this) +
             new TimeSynchronize(DateTime.Now) +
             (List<Byte[]>)_inventory +
             (List<Byte[]>)_gear
             > User).Dispose();


            {
                _scrChrRWLS = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);
                _currentVisibleCharacters = new Dictionary<UInt32, Character>();
                EnterRegion(new Location(Record.MapID, Record.X, Record.Y));
            }


            Log.Info(StrRes.SMSG_LoggedIn);
        }

        public LogProxy Log
        {
            get { return User.Log; }
        }

        public void Dispose()
        {
            ExitCurrentRegion();
            ClearScreen();
            Log.Info(StrRes.SMSG_LoggedOut);

            User = null;
        }

        public bool IsDisposed { get; private set; }

        public void ExchangeSpawns(Character with)
        {
            with.User.Send((RoleInfo)this);
            User.Send((RoleInfo)with);
        }

        /// <summary>
        ///     Sends this entity's spawn at the edge of the other character's screen, then sends a jump.
        /// </summary>
        /// <param name="with"></param>
        /// <param name="jmp"></param>
        /// <remarks>
        ///     TODO:
        ///     I'm clearly rushing here. My method for entering into screens gracefully is not proper.
        ///     The position of this entity is relocated, causing other players to exchange invalid spawn info or
        ///     to interact with the player at the old location.
        /// </remarks>
        public void ExchangeAerialSpawns(Character with, Jump jmp)
        {
            Position pos = Location.Position.GetPrevious();
            Position otherPos = with.Location.Position;
            int pDistance = otherPos - pos;
            int gap = MapSettings.Default.PlayerScreenRange - pDistance;
            // since we're outside the screen, subtracting the distance from 
            Position fauxPos = otherPos.GetRelative(pos, gap);
            // the screen distance will always result in a negative value.

            Location.Position.Relocate(fauxPos);
            ExchangeSpawns(with);
            Location.Position.Restore();

            with.User.Send(jmp.Info);
        }

        public static implicit operator RoleInfo(Character characterToSpawn)
        {
            return new RoleInfo(characterToSpawn);
        }

        public void Save()
        {
            Record.X = Location.Position.X;
            Record.Y = Location.Position.Y;
            Record.MapID = Location.MapId;
            Record.InstanceId = Location.Map.Instance;

            Record.Update();
        }

        public void Logout()
        {
            User.Disconnect();
        }

        public void SendToLocal(WorldPacket packet = null, Boolean includeSelf = false)
        {
            if (!packet) packet = this;
            if (includeSelf) User.Send(packet);

            foreach (Character user in _currentVisibleCharacters.Values)
                user.User.Send(packet);
        }

        public override void SpawnTo(WorldClient observer)
        {
            ExchangeSpawns(observer.Character);
        }

        public void Send(WorldPacket packet)
        {
            User.Send(packet);
        }
    }
}