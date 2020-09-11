using System.Diagnostics;

using JustCli.Configuration;
using JustCli.Executors;


namespace JustCli
{
    class Bootstrapper
    {
        

        public static void Run(Command command, string configDirectory)
        {
            Configuration.Configuration configuration = Configurator.GetConfiguration(configDirectory);

            Executor executor = Executor.GetExecutor(command);
            
            executor.Configuration = configuration;
            executor.Execute();
            // switch(command)
            // {
            //     case Command.Run:
            //
            //         string[] command = configuration.Commands.Run.Split(' ',  2);
            //         string fileName = command[0];
            //         string arguments = command[1];
            //
            //         ExecuteCommand(fileName, arguments);
            //
            //         break;
            }
        }

        

        // private static void ExecuteCommand(string fileName, string arguments)
        // {
        //     var process = new Process();
        //
        //     process.StartInfo = new ProcessStartInfo(fileName, arguments)
        //     {
        //         UseShellExecute = false
        //     };
        //
        //     process.Start();
        //     process.WaitForExit();
        // }
    
}
