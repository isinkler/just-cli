using JustCli.Configuration;
using JustCli.Executors;

namespace JustCli
{
    internal class Bootstrapper
    {        
        public static void Run(Command command, string configDirectory)
        {
            Config configuration = Configurator.GetConfiguration(configDirectory);

            var executor = Executor.GetExecutor(command);
            
            executor.Configuration = configuration;
            executor.Execute();           
        }
    }
}
