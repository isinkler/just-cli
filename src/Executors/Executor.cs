using System;
using System.ComponentModel;

namespace JustCli.Executors
{
    public abstract class Executor : IExecutor
    {
        public abstract void Execute();

        public abstract string GetCommandText();

        public static Executor GetExecutor(Command command)
        {
            switch (command)
            {
                case Command.Run:
                    return new Run();

                case Command.None:
                    break;

                case Command.Init:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(command), command, null);
            }
            
            throw new InvalidEnumArgumentException();
        }

        public Configuration.Configuration Configuration { get; set; }
    }
}
