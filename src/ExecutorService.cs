using Autofac.Features.Indexed;

using JustCli.Executors;

namespace JustCli
{
    public class ExecutorService
    {
        private readonly IIndex<Command, Executor> commandExecutors;

        public ExecutorService (IIndex<Command, Executor> commandExecutors)
        {
            this.commandExecutors = commandExecutors;
        }
        
        public IExecutor GetExecutor(Command command)
        {
            return commandExecutors[command];
        }
    }
}
