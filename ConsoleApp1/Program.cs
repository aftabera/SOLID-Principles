
using ConsoleApp1;

string fileName = "logs.txt";

BaseLogsManager logger = new ConsoleLogsManager();

logger.Log(LogEntryFactory.CreateDefault("Application is starting ..."));
logger.Log(LogEntryFactory.CreateDefault("Application is stopping ..."));

Console.WriteLine("Logs saved successfully!");
