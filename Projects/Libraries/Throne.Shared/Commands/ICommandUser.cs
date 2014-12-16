using System;
using Throne.Shared.Security;

namespace Throne.Shared.Commands
{
    public interface ICommandUser : IPermissible
    {
        void Respond(String response);
        void Respond(Byte[] response);
    }
}