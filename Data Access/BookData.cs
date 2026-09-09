using DataAccess.DTOs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class BookData
    {
        private static readonly string _sourceName = "BookData";

        public static async Task<DataTable> GetAllBooksAsync()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Books ORDER BY BookID ASC";

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

        public static async Task<DataTable> GetAllBooksByCategoryAsync(int categoryId)
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT b.BookID, b.ISBN, b.PublicationDate, b.CategoryID, b.AuthorName, bc.CategoryName FROM Books as b
	inner join BookCategories as bc on b.CategoryID = bc.CategoryID
	where bc.CategoryID = @CategoryID order by b.BookID asc";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", categoryId);
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

        public static int AddBook(BookDTO bookDto)
        {
            int bookId = -1;
            string query = @"INSERT INTO Books (ISBN, PublicationDate, CategoryID, AuthorName)
                             VALUES (@ISBN, @PublicationDate, @CategoryID, @AuthorName);
                             SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ISBN", bookDto.Isbn);
                        command.Parameters.AddWithValue("@PublicationDate", bookDto.PublicationDate);
                        command.Parameters.AddWithValue("@CategoryID", bookDto.CategoryId);
                        command.Parameters.AddWithValue("@AuthorName", bookDto.AuthorName);

                        object result = command.ExecuteScalar();
                        if (result != null)
                            int.TryParse(result.ToString(), out bookId);
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return bookId;
        }

        public static bool UpdateBook(BookDTO bookDto)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Books 
                             SET ISBN = @ISBN, PublicationDate = @PublicationDate,
                                 CategoryID = @CategoryID, AuthorName = @AuthorName
                             WHERE BookID = @BookID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookDto.BookId);
                        command.Parameters.AddWithValue("@ISBN", bookDto.Isbn);
                        command.Parameters.AddWithValue("@PublicationDate", bookDto.PublicationDate);
                        command.Parameters.AddWithValue("@CategoryID", bookDto.CategoryId);
                        command.Parameters.AddWithValue("@AuthorName", bookDto.AuthorName);

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

        public static bool DeleteBook(int bookId)
        {
            int rowsAffected = 0;
            string query = "DELETE FROM Books WHERE BookID = @BookID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookId);
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

        public static bool FindBookById(int bookId, out BookDTO bookDto)
        {
            bookDto = null;
            string query = @"SELECT TOP 1 * FROM Books WHERE BookID = @BookID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bookDto = new BookDTO
                                {
                                    BookId = (int)reader["BookID"],
                                    Isbn = (string)reader["ISBN"],
                                    PublicationDate = (DateTime)reader["PublicationDate"],
                                    CategoryId = (int)reader["CategoryID"],
                                    AuthorName = (string)reader["AuthorName"]
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

            return bookDto != null;
        }

        public static bool FindBookByCategoryId(int categoryId, out BookDTO bookDto)
        {
            bookDto = null;
            string query = @"SELECT TOP 1 * FROM Books WHERE CategoryID = @CategoryID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", categoryId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bookDto = new BookDTO
                                {
                                    BookId = (int)reader["BookID"],
                                    Isbn = (string)reader["ISBN"],
                                    PublicationDate = (DateTime)reader["PublicationDate"],
                                    CategoryId = (int)reader["CategoryID"],
                                    AuthorName = (string)reader["AuthorName"]
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

            return bookDto != null;
        }

        public static bool IsIsbnAlreadyUsed(string isbn)
        {
            bool isUsed = false;
            string query = @"SELECT TOP 1 1 FROM Books WHERE ISBN = @ISBN";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ISBN", isbn);
                        object result = command.ExecuteScalar();
                        isUsed = result != null;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return isUsed;
        }

        public static int TotalCopies(int bookId)
        {
            string query = @"select count (*) from BookCopies as bc
            inner join books as b on b.BookID = bc.BookID
            where b.BookID = @BookID;";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookId);
                        object result = command.ExecuteScalar();

                        int.TryParse(result.ToString(), out int total);
                            return total;
                    }
                }
                catch(Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return -1;
        }
    }
}