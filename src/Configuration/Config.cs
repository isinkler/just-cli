using System;

namespace JustCli.Configuration
{
    public class Config
    {
        public Commands Commands { get; set; } = new Commands();
    }

    public class Commands
    {
        public string Build { get; set; } = String.Empty;
        
        public string Run { get; set; } = String.Empty;

        public string Test { get; set; } = String.Empty;

        public string Init { get; set; } = String.Empty;
    }
}
