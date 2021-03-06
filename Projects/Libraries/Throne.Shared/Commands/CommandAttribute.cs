using System;

namespace Throne.Framework.Commands
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class CommandAttribute : Attribute
    {
        public CommandAttribute(params string[] triggers)
        {
            Triggers = triggers;
        }

        public string[] Triggers { get; private set; }
    }
}