using JustCli.Executors;

namespace JustCli
{
    internal class Bootstrapper
    {
        public static void Run(Command command, string configDirectory)
        {
            var executor = Executor.GetExecutor(command, configDirectory);

            executor.Execute();
        }
    }
}
