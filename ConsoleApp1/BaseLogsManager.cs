namespace ConsoleApp1
{
    public abstract class BaseLogsManager
    {
        public void Log(BaseLogEntry log)
        {
            AppendLogs(log);
        }

        public abstract void AppendLogs(BaseLogEntry log);
    }
}
