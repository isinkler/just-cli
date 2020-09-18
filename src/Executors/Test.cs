namespace JustCli.Executors
{
    public class Test : Executor, ICommandExecutor
    {
        public Test(string directory) : base(directory)
        {
        }

        public override void Execute()
        {
            
        }

        public string GetExecutable()
        {
            throw new System.NotImplementedException();
        }

        public string GetArguments()
        {
            throw new System.NotImplementedException();
        }
    }
}
