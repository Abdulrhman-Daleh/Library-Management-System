using DataAccess.DTOs;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class FinesData
    {
        private static readonly string _sourceName = "FinesData";

        public static int CreateFine(FineDTO fineDto)
        {
            int fineId = -1;
            string query = @"
                INSERT INTO Fines (BorrowID, FineStatusID, FineAmount, Reason, CreatedDate, ClosedDate)
                VALUES (@BorrowID, @FineStatusID, @FineAmount, @Reason, @CreatedDate, @ClosedDate);
                SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowID", fineDto.BorrowId);
                        command.Parameters.AddWithValue("@FineStatusID", fineDto.FineStatusId);
                        command.Parameters.AddWithValue("@FineAmount", fineDto.FineAmount);
                        command.Parameters.AddWithValue("@Reason", fineDto.Reason ?? "");
                        command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                        command.Parameters.AddWithValue("@ClosedDate", fineDto.ClosedDate ?? (object)DBNull.Value);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out fineId)) { }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return fineId;
        }

        public static bool UpdateFine(FineDTO fineDto)
        {
            int rowsAffected = 0;
            string query = @"
                UPDATE Fines 
                SET FineStatusID = @FineStatusID,
                    FineAmount = @FineAmount,
                    ClosedDate = @ClosedDate
                WHERE FineID = @FineID;";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineID", fineDto.FineId);
                        command.Parameters.AddWithValue("@FineStatusID", fineDto.FineStatusId);
                        command.Parameters.AddWithValue("@FineAmount", fineDto.FineAmount);
                        command.Parameters.AddWithValue("@ClosedDate", fineDto.ClosedDate ?? (object)DBNull.Value);

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

        public static FineDTO GetFineByBorrowId(int borrowId)
        {
            FineDTO fineDto = null;
            string query = @"SELECT TOP 1 * FROM Fines WHERE BorrowID = @BorrowID;";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowID", borrowId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fineDto = new FineDTO
                                {
                                    FineId = (int)reader["FineID"],
                                    BorrowId = (int)reader["BorrowID"],
                                    FineStatusId = (int)reader["FineStatusID"],
                                    FineAmount = (decimal)reader["FineAmount"],
                                    Reason = reader["Reason"].ToString(),
                                    CreatedDate = (DateTime)reader["CreatedDate"],
                                    ClosedDate = reader["ClosedDate"] == DBNull.Value ? null : (DateTime?)reader["ClosedDate"]
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

            return fineDto;
        }

        public static FineDTO GetFineById(int fineId)
        {
            FineDTO fineDto = null;
            string query = @"SELECT TOP 1 * FROM Fines WHERE FineID = @FineID;";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineID", fineId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fineDto = new FineDTO
                                {
                                    FineId = (int)reader["FineID"],
                                    BorrowId = reader["BorrowID"] == DBNull.Value ? null : (int?)reader["BorrowID"],
                                    RenewId = reader["RenewID"] == DBNull.Value ? null : (int?)reader["RenewID"],
                                    FineStatusId = (int)reader["FineStatusID"],
                                    FineAmount = (decimal)reader["FineAmount"],
                                    Reason = reader["Reason"].ToString(),
                                    CreatedDate = (DateTime)reader["CreatedDate"],
                                    ClosedDate = reader["ClosedDate"] == DBNull.Value ? null : (DateTime?)reader["ClosedDate"]
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

            return fineDto;
        }

        public static async Task<DataTable> GetAllFinesAsync()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT * FROM Fines ORDER BY FineID ASC";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                            dataTable.Load(reader);
                        else
                            dataTable = null;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return dataTable;
        }

        public static async Task<DataTable> GetAllFinesByMemberIdAsync(int memberId)
        {
            DataTable dataTable = new DataTable();
            string query = @"
                SELECT f.FineID, f.BorrowID, f.FineStatusID, f.FineAmount, f.Reason, f.CreatedDate, f.ClosedDate, f.RenewID
                FROM Fines f
                INNER JOIN BorrowTransactions bt ON bt.BorrowID = f.BorrowID
                WHERE bt.MemberID = @MemberID
                UNION
                SELECT f.FineID, f.BorrowID, f.FineStatusID, f.FineAmount, f.Reason, f.CreatedDate, f.ClosedDate, f.RenewID
                FROM Fines f
                INNER JOIN MembershipRenews mr ON mr.RenewID = f.RenewID
                WHERE mr.MemberID = @MemberID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", memberId);
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                                dataTable.Load(reader);
                            else
                                dataTable = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return dataTable;
        }

        public static bool HasReturnFees(int borrowId)
        {
            bool hasFees = false;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DoesBorrowHasFees", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BorrowID", borrowId);

                        SqlParameter hasFeesParam = new SqlParameter("@HasFees", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(hasFeesParam);
                        command.ExecuteNonQuery();

                        hasFees = (bool)command.Parameters["@HasFees"].Value;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return hasFees;
        }

        public static bool HasMembershipRenewalFees(int renewId)
        {
            bool hasFees = false;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_HasMembershipRenewFees", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RenewID", renewId);

                        SqlParameter hasFeesParam = new SqlParameter("@hasFine", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(hasFeesParam);
                        command.ExecuteNonQuery();

                        hasFees = (bool)command.Parameters["@hasFine"].Value;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return hasFees;
        }

        public static decimal GetAllUnpaidFinesAmount(int memberID)
        {
            decimal total = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_TotalUnpaidFees", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"MemberID", memberID);

                        SqlParameter param = new SqlParameter("@TotalUnpaidFees", SqlDbType.Decimal)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(param);
                        command.ExecuteNonQuery();
                        

                        total = (decimal)command.Parameters["@TotalUnpaidFees"].Value;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return total;
        }
    }
}