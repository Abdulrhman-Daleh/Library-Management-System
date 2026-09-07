using Data_Access.DTOs;
using DataAccess.DTOs;
using System;
using System.Data.SqlClient;

namespace DataAccess
{
    public static class BookConditionData
    {
        private static readonly string _sourceName = "BookConditionData";

        public static BookConditionDTO GetBookConditionById(int conditionId)
        {
            BookConditionDTO conditionDto = null;
            string query = @"SELECT TOP 1 * FROM BookConditions WHERE ConditionID = @ConditionID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ConditionID", conditionId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                conditionDto = new BookConditionDTO
                                {
                                    ConditionId = (int)reader["ConditionID"],
                                    ConditionFees = Convert.ToDecimal(reader["ConditionFees"]),
                                    ConditionTitle = (string)reader["ConditionTitle"]
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return conditionDto;
        }

        public static int GetConditionIdByName(string conditionName)
        {
            int conditionId = -1;
            string query = @"SELECT ConditionID FROM BookConditions WHERE ConditionTitle LIKE @ConditionName";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ConditionName", conditionName);
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out conditionId)) { }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return conditionId;
        }
    }
}