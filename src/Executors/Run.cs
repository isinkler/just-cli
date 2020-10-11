namespace JustCli.Executors
{
    [Command(Command.Run)]
    public class Run : Executor, ICommandExecutor
    {
        public Run(string directory) : base(directory)
        {
        }

        public string GetExecutable()
        {
            string[] command = Configuration.Commands.Run.Split(' ', 2);

            return command[0];
        }

        public string GetArguments()
        {
            string[] command = Configuration.Commands.Run.Split(' ', 2);

            return command[1];
        }

        public override void Execute()
        {
            ExecuteCommand(GetExecutable(), GetArguments());
        }
    }
}
