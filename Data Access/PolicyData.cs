using DataAccess.DTOs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class PolicyData
    {
        private static readonly string _sourceName = "PolicyData";

        public static async Task<DataTable> GetAllPoliciesAsync()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM LibraryPolicy";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        dataTable.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                    return new DataTable();
                }
            }

            return dataTable;
        }

        public static int AddPolicy(PolicyDTO policyDto)
        {
            int policyId = -1;
            string query = @"INSERT INTO LibraryPolicy (FeesPerLateDay, GracePeriodDays, LostBookFeeMultiplier, EffectiveFrom, EffectiveTo)
                             VALUES (@FeesPerLateDay, @GracePeriodDays, @LostBookFeeMultiplier, @EffectiveFrom, @EffectiveTo);
                             SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FeesPerLateDay", policyDto.FeesPerLateDay);
                        command.Parameters.AddWithValue("@GracePeriodDays", policyDto.GracePeriodDays);
                        command.Parameters.AddWithValue("@LostBookFeeMultiplier", policyDto.LostBookFeeMultiplier);
                        command.Parameters.AddWithValue("@EffectiveFrom", policyDto.EffectiveFrom);
                        command.Parameters.AddWithValue("@EffectiveTo", policyDto.EffectiveTo);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out policyId)) { }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);

                }
            }

            return policyId;
        }

        public static bool UpdatePolicy(PolicyDTO policyDto)
        {
            int rowsAffected = -1;
            string query = @"UPDATE LibraryPolicy 
                             SET FeesPerLateDay = @FeesPerLateDay,
                                 GracePeriodDays = @GracePeriodDays,
                                 LostBookFeeMultiplier = @LostBookFeeMultiplier,
                                 EffectiveFrom = @EffectiveFrom,
                                 EffectiveTo = @EffectiveTo
                             WHERE PolicyID = @PolicyID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PolicyID", policyDto.PolicyId);
                        command.Parameters.AddWithValue("@FeesPerLateDay", policyDto.FeesPerLateDay);
                        command.Parameters.AddWithValue("@GracePeriodDays", policyDto.GracePeriodDays);
                        command.Parameters.AddWithValue("@LostBookFeeMultiplier", policyDto.LostBookFeeMultiplier);
                        command.Parameters.AddWithValue("@EffectiveFrom", policyDto.EffectiveFrom);
                        command.Parameters.AddWithValue("@EffectiveTo", policyDto.EffectiveTo);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return rowsAffected > 0;
        }

        public static bool DeletePolicy(int policyId)
        {
            int rowsAffected = -1;
            string query = "DELETE FROM LibraryPolicy WHERE PolicyID = @PolicyID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PolicyID", policyId);
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return rowsAffected > 0;
        }

        public static PolicyDTO GetCurrentActivePolicy()
        {
            PolicyDTO policyDto = null;
            string query = @"SELECT TOP 1 * FROM LibraryPolicy WHERE EffectiveTo >= @CurrentTime";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CurrentTime", DateTime.Now);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                policyDto = new PolicyDTO
                                {
                                    PolicyId = (int)reader["PolicyID"],
                                    FeesPerLateDay = (decimal)reader["FeesPerLateDay"],
                                    GracePeriodDays = (int)reader["GracePeriodDays"],
                                    LostBookFeeMultiplier = (decimal)reader["LostBookFeeMultiplier"],
                                    EffectiveFrom = (DateTime)reader["EffectiveFrom"],
                                    EffectiveTo = (DateTime)reader["EffectiveTo"]
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

            return policyDto;
        }

        public static PolicyDTO GetPolicyById(int policyId)
        {
            PolicyDTO policyDto = null;
            string query = @"SELECT TOP 1 * FROM LibraryPolicy WHERE PolicyID = @PolicyID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PolicyID", policyId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                policyDto = new PolicyDTO
                                {
                                    PolicyId = policyId,
                                    FeesPerLateDay = (decimal)reader["FeesPerLateDay"],
                                    GracePeriodDays = (int)reader["GracePeriodDays"],
                                    LostBookFeeMultiplier = (decimal)reader["LostBookFeeMultiplier"],
                                    EffectiveFrom = (DateTime)reader["EffectiveFrom"],
                                    EffectiveTo = (DateTime)reader["EffectiveTo"]
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

            return policyDto;
        }
    }
}