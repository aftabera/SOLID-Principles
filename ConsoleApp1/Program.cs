
using LogUtility;

var logger = new LogEntry();
logger.Log("Application started ...");
logger.Log("Application stopping ...");

SaveLogs.Save("logs.txt", logger.ToString());

Console.WriteLine("Logs are created & Saved");
