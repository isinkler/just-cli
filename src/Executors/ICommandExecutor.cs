namespace JustCli.Executors
{
    public interface ICommandExecutor
    {
        string GetExecutable();

        string GetArguments();
    }
}
