
using ConsoleApp1;

var logger = new LogsManager();
logger.Log("Application is starting ...");
logger.Log("Application is stopping ...");

logger.SaveLogs("logs.txt");

Console.WriteLine("Logs saved successfully!");
