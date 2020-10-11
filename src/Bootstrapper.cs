using Autofac;

using JustCli.Executors;

namespace JustCli
{
    internal class Bootstrapper
    {
        public static void Run(Command command, string directory)
        {            
            var builder = new ContainerBuilder();

            builder.RegisterType<ExecutorService>().AsSelf();
            builder.RegisterType<Run>().Keyed<IExecutor>(Command.Run).WithParameter(nameof(directory), directory);
            builder.RegisterType<Init>().Keyed<IExecutor>(Command.Init);

            IContainer container = builder.Build();

            using ILifetimeScope scope = container.BeginLifetimeScope();

            var executorService = scope.Resolve<ExecutorService>();
            
            IExecutor executor = executorService.GetExecutor(command);
            executor.Execute();
        }
    }
}
