namespace LogUtility
{
    public class LogEntry
    {
        private List<string> logEntries = new List<string>();

        public void Log(string logEntry)
        {
            logEntries.Add(logEntry);   
        }

        public void RemoveLogAt(int index)
        {
            logEntries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, logEntries);
        }
    }
}
