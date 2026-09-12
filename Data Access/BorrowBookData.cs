using DataAccess.DTOs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class BorrowBookData
    {
        private static readonly string _sourceName = "BorrowBookData";

        public static int CreateBorrowTransaction(BorrowTransactionDTO transactionDto)
        {
            int borrowId = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_BorrowBook", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BookCopyID", transactionDto.BookCopyId);
                        command.Parameters.AddWithValue("@MemberID", transactionDto.MemberId);
                        command.Parameters.AddWithValue("@PolicyID", transactionDto.PolicyId);
                        command.Parameters.AddWithValue("@BorrowStatusID", transactionDto.BorrowStatusId);
                        command.Parameters.AddWithValue("@BorrowDate", transactionDto.BorrowDate);
                        command.Parameters.AddWithValue("@DueDate", transactionDto.DueDate);

                        if (transactionDto.ReturnDate != null)
                            command.Parameters.AddWithValue("@ReturnDate", transactionDto.ReturnDate);
                        else
                            command.Parameters.AddWithValue("@ReturnDate", DBNull.Value);

                        if (transactionDto.LostDate != null)
                            command.Parameters.AddWithValue("@LostDate", transactionDto.LostDate);
                        else
                            command.Parameters.AddWithValue("@LostDate", DBNull.Value);

                        SqlParameter outputParam = new SqlParameter("@BorrowID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputParam);
                        command.ExecuteNonQuery();

                        borrowId = (int)command.Parameters["@BorrowID"].Value;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return borrowId;
        }

        public static bool UpdateBorrowTransaction(int borrowId, int bookCopyId, int newConditionId, int borrowStatusId)
        {
            bool updated = false;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_PerformReturnLostDamaged", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BorrowID", borrowId);
                        command.Parameters.AddWithValue("@BookCopyID", bookCopyId);
                        command.Parameters.AddWithValue("@NewConditionID", newConditionId);
                        command.Parameters.AddWithValue("@BorrowStatus", borrowStatusId);
                        SqlParameter param = new SqlParameter("@Result", SqlDbType.Bit);
                        param.Direction = ParameterDirection.Output;
                        command.Parameters.Add(param);

                        command.ExecuteNonQuery();

                        updated = (bool)param.Value;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return updated;
        }

        public static BorrowTransactionDTO GetBorrowTransactionByCopyId(int bookCopyId)
        {
            BorrowTransactionDTO transactionDto = null;
            string query = @"SELECT * FROM BorrowTransactions WHERE BookCopyID = @BookCopyID and ReturnDate IS NULL ORDER BY BorrowID DESC";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookCopyID", bookCopyId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                transactionDto = new BorrowTransactionDTO
                                {
                                    BorrowId = (int)reader["BorrowID"],
                                    BookCopyId = (int)reader["BookCopyID"],
                                    MemberId = (int)reader["MemberID"],
                                    PolicyId = (int)reader["PolicyID"],
                                    BorrowStatusId = (int)reader["BorrowStatusID"],
                                    BorrowDate = (DateTime)reader["BorrowDate"],
                                    DueDate = (DateTime)reader["DueDate"],
                                    ReturnDate = reader["ReturnDate"] == DBNull.Value ? null : (DateTime?)reader["ReturnDate"],
                                    LostDate = reader["LostDate"] == DBNull.Value ? null : (DateTime?)reader["LostDate"]
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

            return transactionDto;
        }

        public static BorrowTransactionDTO GetBorrowTransactionById(int? borrowId)
        {
            BorrowTransactionDTO transactionDto = null;
            string query = @"SELECT * FROM BorrowTransactions WHERE BorrowID = @BorrowID";

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
                                transactionDto = new BorrowTransactionDTO
                                {
                                    BorrowId = (int)reader["BorrowID"],
                                    BookCopyId = (int)reader["BookCopyID"],
                                    MemberId = (int)reader["MemberID"],
                                    PolicyId = (int)reader["PolicyID"],
                                    BorrowStatusId = (int)reader["BorrowStatusID"],
                                    BorrowDate = (DateTime)reader["BorrowDate"],
                                    DueDate = (DateTime)reader["DueDate"],
                                    ReturnDate = reader["ReturnDate"] == DBNull.Value ? null : (DateTime?)reader["ReturnDate"],
                                    LostDate = reader["LostDate"] == DBNull.Value ? null : (DateTime?)reader["LostDate"]
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

            return transactionDto;
        }

        public static bool IsBookCopyBorrowed(int bookCopyId)
        {
            bool isBorrowed = false;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_IsBookCopyBorrowed", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BookCopyID", bookCopyId);

                        SqlParameter isBorrowedParam = new SqlParameter("IsBorrowed", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(isBorrowedParam);
                        command.ExecuteNonQuery();

                        isBorrowed = (bool)command.Parameters["IsBorrowed"].Value;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return isBorrowed;
        }

        public static async Task<DataTable> GetBorrowTransactionsAsync()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT * FROM BorrowTransactions ORDER BY BorrowID ASC";

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

        public static async Task<DataTable> GetBorrowTransactionsByMemberIdAsync(int memberId)
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT * FROM BorrowTransactions WHERE MemberID = @MemberID ORDER BY BorrowID ASC";

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

        public static int GetTotalBorrowedTransactionForMember(int memberId)
        {
            string query = @"select count(*) from BorrowTransactions as bt inner join BorrowStatus as bs
              on bs.BorrowStatusID = bt.BorrowStatusID where bs.BorrowStatusTitle = 'Borrow' and bt.ReturnDate is null and MemberID = @memberID;";

            int borrowedCount = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@memberID", memberId);
                        object result = command.ExecuteScalar();

                        if (result is null)
                            return default(int);
                        else
                            borrowedCount = (int)result;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return borrowedCount;
        }

        public static short GetTotalOverdueTransactionForMember(int memberId)
        {
            string query = @"select count(*) from BorrowTransactions as bt

	where bt.DueDate < Getdate() and bt.ReturnDate is null and MemberID = @memberID;";

            short overdueCount = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@memberID", memberId);
                        object result = command.ExecuteScalar();

                        if (result is null)
                            return default(int);
                        else
                            overdueCount = (short)result;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return overdueCount;
        }
    }
}