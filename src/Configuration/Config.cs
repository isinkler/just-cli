namespace JustCli.Configuration
{
    public class Config
    {
        public Commands Commands { get; set; }
    }

    public class Commands
    {
        public string Run { get; set; }

        public string Init { get; set; }
    }
}
