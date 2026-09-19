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

        public static FineDTO GetFineByBorrowId(int borrowId)
        {
            FineDTO fineDto = null;
            string query = @"SELECT TOP 1 FineID,
                            BorrowID,
                            FineStatusID,
                            FineAmount,
                            Reason,
                            CreatedDate,
                            ClosedDate,
                            RenewID FROM Fines WHERE BorrowID = @BorrowID;";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@BorrowID", SqlDbType.Int).Value = borrowId;
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
            string query = @"SELECT TOP 1 FineID,
                            BorrowID,
                            FineStatusID,
                            FineAmount,
                            Reason,
                            CreatedDate,
                            ClosedDate,
                            RenewID FROM Fines WHERE FineID = @FineID;";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@FineID", SqlDbType.Int).Value = fineId;
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
            string query = @"SELECT FineID,
                    BorrowID,
                    FineStatusID,
                    FineAmount,
                    Reason,
                    CreatedDate,
                    ClosedDate,
                    RenewID FROM Fines ORDER BY FineID ASC";

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
                        command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberId;
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                                dataTable.Load(reader);
                        }
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
                        command.Parameters.Add("@BorrowID", SqlDbType.Int).Value = borrowId;

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
                        command.Parameters.Add("@RenewID", SqlDbType.Int).Value = renewId;

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
                        command.Parameters.Add(@"MemberID", SqlDbType.Int).Value = memberID;

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