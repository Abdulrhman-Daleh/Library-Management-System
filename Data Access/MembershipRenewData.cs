using DataAccess.DTOs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class MembershipRenewData
    {
        private static readonly string _sourceName = "MembershipRenewData";

        public static int Add(MembershipRenewDTO renewDto)
        {
            int renewId = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("SP_AddMembershipRenew", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MemberID", renewDto.MemberId);
                    command.Parameters.AddWithValue("@MembershipTypeID", renewDto.MembershipTypeId);
                    command.Parameters.AddWithValue("@RenewDate", renewDto.RenewDate);
                    command.Parameters.AddWithValue("@RenewFees", renewDto.RenewFees);
                    command.Parameters.AddWithValue("@IsPaid", renewDto.IsPaid);

                    SqlParameter outputParam = new SqlParameter("@RenewID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(outputParam);

                    connection.Open();
                    command.ExecuteNonQuery();

                    renewId = (int)outputParam.Value;
                }
            }

            return renewId;
        }

        public static int GetMemberIdByFineId(int? renewId)
        {
            int memberId = -1;
            string query = @"SELECT MemberID FROM MembershipRenews WHERE RenewID = @RenewID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if(renewId.HasValue)
                        command.Parameters.AddWithValue("@RenewID", renewId);
                        else
                            command.Parameters.AddWithValue("@RenewID", DBNull.Value);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out memberId)) { }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return memberId;
        }

        public static bool Update(MembershipRenewDTO renewDto)
        {
            int rowsAffected = 0;
            string query = @"
                UPDATE MembershipRenews
                SET MemberID = @MemberID,
                    MembershipTypeID = @MembershipTypeID,
                    RenewDate = @RenewDate,
                    RenewFees = @RenewFees,
                    IsPaid = @IsPaid
                WHERE RenewID = @RenewID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RenewID", renewDto.RenewId);
                        command.Parameters.AddWithValue("@MemberID", renewDto.MemberId);
                        command.Parameters.AddWithValue("@MembershipTypeID", renewDto.MembershipTypeId);
                        command.Parameters.AddWithValue("@RenewDate", renewDto.RenewDate);
                        command.Parameters.AddWithValue("@RenewFees", renewDto.RenewFees);
                        command.Parameters.AddWithValue("@IsPaid", renewDto.IsPaid);

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

        public static bool Delete(int renewId)
        {
            int rowsAffected = 0;
            string query = "DELETE FROM MembershipRenews WHERE RenewID = @RenewID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RenewID", renewId);
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

        public static MembershipRenewDTO FindByRenewId(int? renewId)
        {
            MembershipRenewDTO renewDto = null;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                string query = @"SELECT * FROM MembershipRenews WHERE RenewID = @RenewID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if(renewId.HasValue)
                    command.Parameters.AddWithValue("@RenewID", renewId);
                    else
                        command.Parameters.AddWithValue("@RenewID", DBNull.Value);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            renewDto = new MembershipRenewDTO
                            {
                                RenewId = (int)reader["RenewID"],
                                MemberId = (int)reader["MemberID"],
                                MembershipTypeId = (int)reader["MembershipTypeID"],
                                RenewDate = (DateTime)reader["RenewDate"],
                                RenewFees = (decimal)reader["RenewFees"],
                                IsPaid = (bool)reader["IsPaid"]
                            };
                        }
                    }
                }
            }

            return renewDto;
        }

        public static MembershipRenewDTO FindByMemberId(int memberId)
        {
            MembershipRenewDTO renewDto = null;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                string query = @"SELECT TOP 1 * FROM MembershipRenews WHERE MemberID = @MemberID ORDER BY RenewDate DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberId);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            renewDto = new MembershipRenewDTO
                            {
                                RenewId = (int)reader["RenewID"],
                                MemberId = (int)reader["MemberID"],
                                MembershipTypeId = (int)reader["MembershipTypeID"],
                                RenewDate = (DateTime)reader["RenewDate"],
                                RenewFees = (decimal)reader["RenewFees"],
                                IsPaid = (bool)reader["IsPaid"]
                            };
                        }
                    }
                }
            }

            return renewDto;
        }

        public static async Task<DataTable> GetAllRenewalsAsync()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                string query = @"SELECT * FROM MembershipRenews";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                            dataTable.Load(reader);
                    }
                }
            }

            return dataTable;
        }

        public static async Task<DataTable> GetAllRenewalsByMemberIdAsync(int memberId)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                string query = @"SELECT * FROM MembershipRenews WHERE MemberID = @MemberID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    await connection.OpenAsync();
                    command.Parameters.AddWithValue("@MemberID", memberId);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                            dataTable.Load(reader);
                    }
                }
            }

            return dataTable;
        }

        public static DataTable GetRenewalsByMemberId(int memberId)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                string query = @"SELECT * FROM MembershipRenews WHERE MemberID = @MemberID ORDER BY RenewDate DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberId);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dataTable.Load(reader);
                    }
                }
            }

            return dataTable;
        }
    }
}