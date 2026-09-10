using System;
using System.Configuration;

namespace DataAccess
{
    public class ConnectionAccess
    {
        public static string GetConnectionString()
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

                if(string.IsNullOrEmpty(connectionString))
                {
                    throw new ConfigurationErrorsException("Connection string 'DbConnection' is missing or empty in App.config.");
                }

                return connectionString;
            }
            catch (Exception ex)
            {
                DataLogger.LogError("ConnectionAccess", ex.ToString());
                return null;
            }
        }
    }
}