using System;
using System.IO;

using McMaster.Extensions.CommandLineUtils;

// ReSharper disable once UnusedMember.Local

namespace JustCli
{
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
            Console.WriteLine(Command);
            Console.WriteLine(ConfigDirectory);
            Bootstrapper.Run(Command, ConfigDirectory);
        }
    }
}
