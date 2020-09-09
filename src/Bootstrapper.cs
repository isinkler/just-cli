using Newtonsoft.Json;

using System;
using System.Diagnostics;
using System.IO;

namespace JustCli
{
    class Bootstrapper
    {
        private const string ConfigFileName = "just.json";

        static void Main(string[] args)
        {
            Configuration configuration = GetConfiguration();

            var command = configuration.Commands.Start.Split(' ', 2);

            ExecuteCommand(command);
        }

        private static Configuration GetConfiguration()
        {
            string currentDirectoryPath = Directory.GetCurrentDirectory();
            string configFilePath = $"{currentDirectoryPath}\\{ConfigFileName}";

            try
            {
                string configFileContent = File.ReadAllText(configFilePath);

                Configuration configuration = JsonConvert.DeserializeObject<Configuration>(configFileContent);

                return configuration;

            } catch(FileNotFoundException)
            {
                Console.WriteLine("just can't find a just.json file in your current directory.");

                Environment.Exit(0);
            }

            return default;
        }

        private static void ExecuteCommand(string[] command)
        {
            var process = new Process();

            process.StartInfo = new ProcessStartInfo(command[0], command[1])
            {
                UseShellExecute = false
            };

            process.Start();
            process.WaitForExit();
        }
    }
}
