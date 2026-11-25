using System.Diagnostics;
using System.Text;

namespace PZ.RxAvalonia.Shared.Service;

public class LogService
{
    private static string GetLogFilePath()
    {
        string root = AppDomain.CurrentDomain.BaseDirectory;
        string logDir = Path.Join(root, "Logs");
        if (!Directory.Exists(logDir))
        {
            Directory.CreateDirectory(logDir);
        }
        return Path.Combine(logDir, $"log_{DateTime.Now:yyyyMMdd}.txt");
    }

    public void Log(string message)
    {
        Debug.WriteLine(message);
        try
        {
            var logFile = GetLogFilePath();
            File.AppendAllText(logFile, message, Encoding.UTF8);
        }
        catch (Exception ex)
        {
            // Log failed
            Debug.WriteLine(ex.Message);
        }
    }

    public void Error(Exception ex)
    {
        string exceptionLog = $"\r\n[{DateTime.Now:yyyy-MM-dd HH:mm:ss.ff}] {ex}\r\n";
        Log(exceptionLog);
    }
}

