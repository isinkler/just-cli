using System;

using JustCli.Configuration;

namespace JustCli.Executors
{
    public class Init : Executor
    {
        public override void Execute()
        {
            Configurator.InitConfiguration();
        }

        public override string GetExecutable()
        {
            throw new NotImplementedException();
        }

        public override string GetArguments()
        {
            throw new NotImplementedException();
        }
    }
}
