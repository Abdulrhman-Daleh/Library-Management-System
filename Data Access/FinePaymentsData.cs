using DataAccess.DTOs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class FinePaymentsData
    {
        private static readonly string _sourceName = "FinePaymentsData";

        public static async Task<DataTable> GetAllFinePaymentsAsync()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT PaymentID, FineID, AmountPaid, PaymentDate, PaymentMethod FROM FinePayments;";

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
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError("FinePaymentsData", ex.Message);
                }
            }

            return dataTable;
        }

        public static async Task<DataTable> GetAllFinePaymentsByMemberIdAsync(int memberId)
        {
            DataTable dataTable = new DataTable();
            string query = @"
                SELECT PaymentID FROM FinePayments AS fp
                INNER JOIN Fines AS f ON fp.FineID = f.FineID
                INNER JOIN BorrowTransactions AS bt ON bt.BorrowID = f.BorrowID
                WHERE MemberID = @MemberID
                UNION
                SELECT PaymentID FROM FinePayments AS fp
                INNER JOIN Fines AS f ON fp.FineID = f.FineID
                INNER JOIN MembershipRenews AS mr ON mr.RenewID = f.RenewID
                WHERE MemberID = @MemberID";

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
                        }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError("FinePaymentsData", ex.Message);
                }
            }

            return dataTable;
        }

        public static FinePaymentDTO GetPaymentByBorrowId(int borrowId)
        {
            FinePaymentDTO paymentDto = null;
            string query = @"
                SELECT TOP 1 fp.*
                FROM FinePayments fp
                INNER JOIN Fines f ON f.FineID = fp.FineID
                WHERE f.BorrowID = @BorrowID;";

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
                                paymentDto = new FinePaymentDTO
                                {
                                    PaymentId = (int)reader["PaymentID"],
                                    FineId = (int)reader["FineID"],
                                    AmountPaid = (decimal)reader["AmountPaid"],
                                    PaymentDate = (DateTime)reader["PaymentDate"],
                                    PaymentMethod = (string)reader["PaymentMethod"]
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

            return paymentDto;
        }

        public static FinePaymentDTO GetPaymentById(int paymentId)
        {
            FinePaymentDTO paymentDto = null;
            string query = @"
                SELECT fp.*
                FROM FinePayments fp
                INNER JOIN Fines f ON f.FineID = fp.FineID
                WHERE fp.PaymentID = @PaymentID;";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", paymentId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                paymentDto = new FinePaymentDTO
                                {
                                    PaymentId = (int)reader["PaymentID"],
                                    FineId = (int)reader["FineID"],
                                    AmountPaid = (decimal)reader["AmountPaid"],
                                    PaymentDate = (DateTime)reader["PaymentDate"],
                                    PaymentMethod = (string)reader["PaymentMethod"]
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

            return paymentDto;
        }

        public static decimal GetTotalAmountPaidByFineId(int fineId)
        {
            decimal totalAmountPaid = 0;
            string query = @"SELECT SUM(AmountPaid) FROM FinePayments WHERE FineID = @FineID;";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineID", fineId);
                        object result = command.ExecuteScalar();
                        if (result != null && decimal.TryParse(result.ToString(), out decimal amount))
                            totalAmountPaid = amount;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return totalAmountPaid;
        }

        public static int CreateFinePayment(FinePaymentDTO paymentDto, int? renewId)
        {
            int paymentId = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FinePayment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FineID", paymentDto.FineId);
                        command.Parameters.AddWithValue("@AmountPaid", paymentDto.AmountPaid);
                        command.Parameters.AddWithValue("@PaymentMethod", paymentDto.PaymentMethod);

                        if(renewId != null)
                          command.Parameters.AddWithValue("@RenewID", renewId);
                        else
                           command.Parameters.AddWithValue("@RenewID", DBNull.Value);


                        SqlParameter outputParam = new SqlParameter("@PaymentID", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.Output
                            };

                        command.Parameters.Add(outputParam);
                        command.ExecuteScalar();

                        paymentId = (int)command.Parameters["@PaymentID"].Value;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return paymentId;
        }

        public static bool UpdateFinePayment(FinePaymentDTO paymentDto)
        {
            int rowsAffected = 0;
            string query = @"
                UPDATE FinePayments 
                SET FineID = @FineID,
                    AmountPaid = @AmountPaid,
                    PaymentDate = @PaymentDate,
                    PaymentMethod = @PaymentMethod
                WHERE PaymentID = @PaymentID;";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", paymentDto.PaymentId);
                        command.Parameters.AddWithValue("@FineID", paymentDto.FineId);
                        command.Parameters.AddWithValue("@AmountPaid", paymentDto.AmountPaid);
                        command.Parameters.AddWithValue("@PaymentDate", paymentDto.PaymentDate);
                        command.Parameters.AddWithValue("@PaymentMethod", paymentDto.PaymentMethod);

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
    }
}