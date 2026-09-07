using DataAccess.DTOs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class BookCopyData
    {
        private static readonly string _sourceName = "BookCopyData";

        public static async Task<DataTable> GetAllBookCopiesAsync()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT BookCopyID, BookID, AddedDate, StatusID, ConditionID, BookCopyPrice 
                             FROM BookCopies ORDER BY BookCopyID ASC";

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
                            dataTable = new DataTable();
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return dataTable;
        }

        public static async Task<DataTable> GetAllBookCopiesByBookIdAsync(int bookId)
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT BookCopyID, BookID, AddedDate, StatusID, ConditionID, BookCopyPrice 
                             FROM BookCopies WHERE BookID = @BookID ORDER BY BookCopyID ASC";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookId);
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                                dataTable.Load(reader);
                            else
                                dataTable = new DataTable();
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

        public static int AddBookCopy(BookCopyDTO bookCopyDto)
        {
            int bookCopyId = -1;
            string query = @"INSERT INTO BookCopies (BookID, AddedDate, StatusID, ConditionID, BookCopyPrice)
                             VALUES (@BookID, @AddedDate, @StatusID, @ConditionID, @BookCopyPrice);
                             SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookCopyDto.BookId);
                        command.Parameters.AddWithValue("@AddedDate", bookCopyDto.AddedDate);
                        command.Parameters.AddWithValue("@StatusID", bookCopyDto.StatusId);
                        command.Parameters.AddWithValue("@ConditionID", bookCopyDto.ConditionId);
                        command.Parameters.AddWithValue("@BookCopyPrice", bookCopyDto.BookCopyPrice);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out bookCopyId)) { }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return bookCopyId;
        }

        public static bool UpdateBookCopy(BookCopyDTO bookCopyDto)
        {
            int rowsAffected = 0;
            string query = @"UPDATE BookCopies 
                             SET StatusID = @StatusID, ConditionID = @ConditionID, BookCopyPrice = @BookCopyPrice
                             WHERE BookCopyID = @BookCopyID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookCopyID", bookCopyDto.BookCopyId);
                        command.Parameters.AddWithValue("@StatusID", bookCopyDto.StatusId);
                        command.Parameters.AddWithValue("@ConditionID", bookCopyDto.ConditionId);
                        command.Parameters.AddWithValue("@BookCopyPrice", bookCopyDto.BookCopyPrice);

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

        public static bool DeleteBookCopy(int bookCopyId)
        {
            int rowsAffected = 0;
            string query = "DELETE FROM BookCopies WHERE BookCopyID = @BookCopyID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookCopyID", bookCopyId);
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

        public static bool FindBookCopyById(int bookCopyId, out BookCopyDTO bookCopyDto)
        {
            bookCopyDto = null;
            string query = @"SELECT TOP 1 * FROM BookCopies WHERE BookCopyID = @BookCopyID";

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
                                bookCopyDto = new BookCopyDTO
                                {
                                    BookCopyId = (int)reader["BookCopyID"],
                                    BookId = (int)reader["BookID"],
                                    AddedDate = (DateTime)reader["AddedDate"],
                                    StatusId = Convert.ToByte(reader["StatusID"]),
                                    ConditionId = Convert.ToByte(reader["ConditionID"]),
                                    BookCopyPrice = Convert.ToDecimal(reader["BookCopyPrice"])
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

            return bookCopyDto != null;
        }

        public static decimal GetBookConditionFees(int bookCopyId)
        {
            decimal conditionFees = -1;
            string query = @"SELECT ConditionFees 
                             FROM BookConditions 
                             INNER JOIN BookCopies ON BookConditions.ConditionID = BookCopies.ConditionID 
                             WHERE BookCopyID = @BookCopyID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookCopyID", bookCopyId);
                        object result = command.ExecuteScalar();
                        if (result != null)
                            conditionFees = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return conditionFees;
        }

        public static bool ChangeBookCopyStatus(int bookCopyId, int newStatusId)
        {
            int rowsAffected = 0;
            string query = @"UPDATE BookCopies SET StatusID = @StatusID WHERE BookCopyID = @BookCopyID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookCopyID", bookCopyId);
                        command.Parameters.AddWithValue("@StatusID", newStatusId);
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

        public static bool UpdateBookCopyCondition(int bookCopyId, int newConditionId)
        {
            int rowsAffected = 0;
            string query = @"UPDATE BookCopies SET ConditionID = @ConditionID WHERE BookCopyID = @BookCopyID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookCopyID", bookCopyId);
                        command.Parameters.AddWithValue("@ConditionID", newConditionId);
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

        public static bool IsBookCopyAvailable(int bookCopyId)
        {
            bool isAvailable = false;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_CheckCopyIfAvailable", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BookCopyID", bookCopyId);

                        SqlParameter availableParam = new SqlParameter("@IsAvailable", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(availableParam);
                        command.ExecuteNonQuery();

                        isAvailable = (bool)command.Parameters["@IsAvailable"].Value;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return isAvailable;
        }
    }
}