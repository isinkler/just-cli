using System;
using System.ComponentModel;
using System.Diagnostics;

using JustCli.Configuration;

namespace JustCli.Executors
{
    public abstract class Executor : IExecutor
    {
        protected Executor ()
        {
            
        }
        
        protected Executor(string directory)
        {
            Configuration = Configurator.GetConfiguration(directory);
        }

        protected Config Configuration { get; set; }

        public abstract void Execute();

        public abstract string GetExecutable();

        public abstract string GetArguments();

        public static Executor GetExecutor(Command command, string directory)
        {
            switch (command)
            {
                case Command.Run:
                    return new Run(directory);

                case Command.Init:
                    return new Init();

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
    }
}
