using System;
using System.Diagnostics;

namespace DataAccess
{
    public class DataLogger
    {
        private static void EnsureLogSource(string sourceName)
        {
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }
        }

        public static void LogError(string source, string message)
        {
              EnsureLogSource(source);
              EventLog.WriteEntry(source, message, EventLogEntryType.Error);
        }
    }
}