using System.ComponentModel;

namespace JustCli
{
    public enum Command
    {
        None = 0,
        
        [Description("build")]
        Build = 1,

        [Description("run")]
        Run = 2,
        
        [Description("test")]
        Test = 3,
        
        [Description("init")]
        Init = 99
    }
}
