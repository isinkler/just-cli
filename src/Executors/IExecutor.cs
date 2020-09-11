namespace JustCli.Executors
{
    public interface IExecutor
    {
        void Execute();
        
        string GetExecutable();
        
        string GetArguments();
    }
}
