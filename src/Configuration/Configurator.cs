﻿using System;
using System.IO;

using Newtonsoft.Json;

namespace JustCli.Configuration
{
    public class Configurator
    {
        private const string ConfigFileName = "just.json";

        public static Config GetConfiguration(string configDirectory)
        {
            var configFilePath = $"{configDirectory}\\{ConfigFileName}";

            try
            {
                string configFileContent = File.ReadAllText(configFilePath);

                var configuration = JsonConvert.DeserializeObject<Config>(configFileContent);

                return configuration;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("just can't find a just.json file in your current directory.");

                Environment.Exit(0);
            }

            return default;
        }

        public static void InitConfiguration()
        {
            var configFilePath = $"{Directory.GetCurrentDirectory()}\\{ConfigFileName}";

            var config = new Config();
            config.Commands = new Commands();
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);

            File.WriteAllText(configFilePath, json);
        }
    }
}
