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
                return ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            }
            catch (Exception ex)
            {
                DataLogger.LogError("ConnectionAccess", ex.Message);
                return null;
            }
        }
    }
}