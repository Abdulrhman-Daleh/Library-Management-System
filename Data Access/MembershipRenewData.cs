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

        public static MembershipRenewDTO FindByRenewId(int? renewId)
        {
            MembershipRenewDTO renewDto = null;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                string query = @"SELECT * FROM MembershipRenews WHERE RenewID = @RenewID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (renewId.HasValue)
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

        public static async Task<DataTable> GetAllRenewalsAsync()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    string query = @"SELECT * FROM MembershipRenews";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        await connection.OpenAsync();

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError("MembershipRenewData", ex.Message);
                    return new DataTable();
                }
            }

            return dataTable;
        }

        public static async Task<DataTable> GetAllRenewalsByMemberIdAsync(int memberId)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    string query = @"SELECT * FROM MembershipRenews WHERE MemberID = @MemberID";

                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", memberId);
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError("MembershipRenewData", ex.Message);
                    return new DataTable();
                }
            }

            return dataTable;
        }

    }
}