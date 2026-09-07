using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class BookCategoriesData
    {
        private static readonly string _sourceName = "BookCategoryData";

        public static async Task<DataTable> GetAllCategoriesAsync()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM BookCategories ORDER BY CategoryID ASC;";

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
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return dataTable;
        }

        public static List<string> GetAllCategoryNames()
        {
            List<string> categoryNames = new List<string>();
            string query = "SELECT CategoryName FROM BookCategories ORDER BY CategoryID ASC;";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            categoryNames.Add(reader.GetValue(0).ToString());
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return categoryNames;
        }

        public static int AddCategory(BookCategoriesDTO categoryDto)
        {
            int categoryId = -1;
            string query = @"INSERT INTO BookCategories (CategoryName, CategoryDescription)
                             VALUES (@CategoryName, @CategoryDescription);
                             SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryName", categoryDto.CategoryName);

                        if (string.IsNullOrEmpty(categoryDto.CategoryDescription))
                            command.Parameters.AddWithValue("@CategoryDescription", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@CategoryDescription", categoryDto.CategoryDescription);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out categoryId)) { }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return categoryId;
        }

        public static bool UpdateCategory(BookCategoriesDTO categoryDto)
        {
            int rowsAffected = -1;
            string query = @"UPDATE BookCategories 
                             SET CategoryName = @CategoryName, 
                                 CategoryDescription = @CategoryDescription
                             WHERE CategoryID = @CategoryID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", categoryDto.CategoryId);
                        command.Parameters.AddWithValue("@CategoryName", categoryDto.CategoryName);

                        if (string.IsNullOrEmpty(categoryDto.CategoryDescription))
                            command.Parameters.AddWithValue("@CategoryDescription", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@CategoryDescription", categoryDto.CategoryDescription);

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

        public static BookCategoriesDTO GetCategoryById(int categoryId)
        {
            BookCategoriesDTO categoryDto = null;
            string query = @"SELECT TOP 1 * FROM BookCategories WHERE CategoryID = @CategoryID";

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
                                categoryDto = new BookCategoriesDTO
                                {
                                    CategoryId = (int)reader["CategoryID"],
                                    CategoryName = (string)reader["CategoryName"],
                                    CategoryDescription = reader["CategoryDescription"] == DBNull.Value ? "" : reader["CategoryDescription"].ToString()
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

            return categoryDto;
        }

        public static BookCategoriesDTO GetCategoryByName(string categoryName)
        {
            BookCategoriesDTO categoryDto = null;
            string query = @"SELECT TOP 1 * FROM BookCategories WHERE CategoryName = @CategoryName";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryName", categoryName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                categoryDto = new BookCategoriesDTO
                                {
                                    CategoryId = (int)reader["CategoryID"],
                                    CategoryName = (string)reader["CategoryName"],
                                    CategoryDescription = reader["CategoryDescription"] == DBNull.Value ? "" : reader["CategoryDescription"].ToString()
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

            return categoryDto;
        }

        public static bool DeleteCategoryById(int categoryId)
        {
            int rowsAffected = -1;
            string query = "DELETE FROM BookCategories WHERE CategoryID = @CategoryID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", categoryId);
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