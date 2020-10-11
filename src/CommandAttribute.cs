using System;

namespace JustCli
{
    public class CommandAttribute : Attribute
    {

        public CommandAttribute (Command command)
        {
            Command = command;
        }

        public Command Command { get; set; }
    }
}
