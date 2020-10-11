namespace JustCli.Executors
{
    public class Build : Executor, ICommandExecutor
    {
        public Build (string directory) : base(directory)
        {
            
        }
        
        public override void Execute()
        {
            throw new System.NotImplementedException();
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
