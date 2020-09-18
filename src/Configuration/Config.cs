namespace JustCli.Configuration
{
    public class Config
    {
        public Commands Commands { get; set; }
    }

    public class Commands
    {
        public string Build { get; set; }
        
        public string Run { get; set; }

        public string Test { get; set; }

        public string Init { get; set; }
    }
}
