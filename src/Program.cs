using System;
using System.IO;

using McMaster.Extensions.CommandLineUtils;

namespace JustCli
{
    /// <summary>
    /// dotnet tool install --global --add-source .\src\nupkg\ just-cli
    /// dotnet pack
    /// dotnet tool uninstall -g just-cli
    /// </summary>
    internal class Program
    {
        [Argument(0, Description = "Command to execute.")]
        public Command Command { get; set; }

        [Option("-d|--directory", Description = "The directory where the just.json file is present.")]
        public string ConfigDirectory { get; set; } = Directory.GetCurrentDirectory();

        private static void Main(string[] args)
        {
            CommandLineApplication.Execute<Program>(args);
        }

        private void OnExecute()
        {            
            Bootstrapper.Run(Command, ConfigDirectory);
        }
    }
}
