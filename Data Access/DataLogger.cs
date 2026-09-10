using System;
using System.Diagnostics;
using System.IO;

namespace DataAccess
{
    public class DataLogger
    {
        private static void EnsureLogSource(string sourceName)
        {
            if (!EventLog.SourceExists(sourceName))
            {
                try
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }
                catch(Exception ex)
                {

                }
            }
        }

        public static void LogError(string source, string message)
        {
            try
            {
                EnsureLogSource(source);
                EventLog.WriteEntry(source, message, EventLogEntryType.Error);
            }
            catch(Exception ex)
            {
                try
                {
                    string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs", "app.log");
                    Directory.CreateDirectory(Path.GetDirectoryName(logPath));
                    File.AppendAllText(logPath,
                        $"[{DateTime.Now}] [{source}] {message}\n{ex}\n\n");
                }
                catch
                {

                }
            }
        }
    }
}