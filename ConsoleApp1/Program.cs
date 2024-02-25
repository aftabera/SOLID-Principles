
using ConsoleApp1;

string fileName = "logs.txt";

var logger = new FileLogsManager(fileName);

logger.Log(LogEntryFactory.CreateDefault("Application is starting ..."));
logger.Log(LogEntryFactory.CreateDefault("Application is stopping ..."));

Console.WriteLine("Logs saved successfully!");
