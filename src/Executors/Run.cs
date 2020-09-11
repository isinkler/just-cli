namespace JustCli.Executors
{
    public class Run : Executor
    {
        public override void Execute()
        {
            ExecuteCommand(GetExecutable(), GetArguments());
        }

        public override string GetExecutable()
        {
            string[] command = Configuration.Commands.Run.Split(' ', 2);
            
            return command[0];
        }

        public override string GetArguments()
        {
            string[] command = Configuration.Commands.Run.Split(' ', 2);
            
            return command[1];
        }
    }
}
