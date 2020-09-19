using System;
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
