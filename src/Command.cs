using System.ComponentModel;

namespace JustCli
{
    public enum Command
    {
        [Description("run")]
        Run = 1,

        None = 0,

        [Description("init")]
        Init = 99
    }
}
