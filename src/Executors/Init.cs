using JustCli.Configuration;

namespace JustCli.Executors
{
    public class Init : Executor
    {
        public override void Execute()
        {
            Configurator.InitConfiguration();
        }
    }
}
