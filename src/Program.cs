﻿using System;
using System.IO;

using McMaster.Extensions.CommandLineUtils;

namespace JustCli
{
    class Program
    {
        static void Main(string[] args) => CommandLineApplication.Execute<Program>(args);
        
        [Argument(0, Description = "Command to execute.")]
        public Command Command {get; set;}

        [Option("-d|--directory", Description = "The directory where the just.json file is present.")]
        public string ConfigDirectory { get; set; } = Directory.GetCurrentDirectory();
        
        private void OnExecute()
        {
            Console.WriteLine(Command);
            Console.WriteLine(ConfigDirectory);
            Bootstrapper.Run(Command, ConfigDirectory);
        }
        
        private static void ShowUsage()
        {
            throw new NotImplementedException();
        }
    }
}
