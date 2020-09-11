using JustCli.Configuration;

using System;
using System.ComponentModel;
using System.Diagnostics;

namespace JustCli.Executors
{
    public abstract class Executor : IExecutor
    {
        public abstract void Execute();

        public abstract string GetExecutable();

        public abstract string GetArguments();

        public static Executor GetExecutor(Command command)
        {
            switch (command)
            {
                case Command.Run:
                    return new Run();
                
                case Command.Init:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(command), command, null);
            }
            
            throw new InvalidEnumArgumentException();
        }

        protected virtual void ExecuteCommand(string fileName, string arguments)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo(fileName, arguments)
                {
                    UseShellExecute = false
                }
            };

            process.Start();
            process.WaitForExit();
        }

        public Config Configuration { get; set; }
    }
}
