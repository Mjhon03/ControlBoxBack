using System;
using System.IO;

public class ActivityLogger
{
    private readonly string logFilePath;

    public ActivityLogger(string logFilePath)
    {
        this.logFilePath = logFilePath;
    }

    public void LogActivity(string message)
    {
        string logEntry = $"{DateTime.Now} - {message}";

        try
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(logEntry);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al escribir en el archivo de log: {ex.Message}");
        }
    }
}
