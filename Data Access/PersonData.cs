using DataAccess.DTOs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class PersonData
    {
        private static readonly string _sourceName = "PersonData";

        public static async Task<DataTable> GetAllPeopleAsync()
        {
            DataTable peopleDataTable = new DataTable();
            string query = @"SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Email,
                             CASE WHEN Gender = '0' THEN 'Male' ELSE 'Female' END AS Gender,
                             Phone, Address FROM People;";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                            peopleDataTable.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                    return new DataTable();
                }
            }

            return peopleDataTable;
        }

        public static async Task<DataTable> GetPeopleByPersonIdAsync(int personId)
        {
            DataTable peopleDataTable = new DataTable();
            string query = @"SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Email,
                             CASE WHEN Gender = '0' THEN 'Male' ELSE 'Female' END AS Gender,
                             Phone, Address FROM People WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", personId);
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                                peopleDataTable.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                    return new DataTable();
                }
            }

            return peopleDataTable;
        }

        public static PersonDTO GetPersonById(int personId)
        {
            PersonDTO personDto = null;
            string query = @"SELECT * FROM People WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", personId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                personDto = new PersonDTO
                                {
                                    PersonId = personId,
                                    NationalNo = (string)reader["NationalNo"],
                                    FirstName = (string)reader["FirstName"],
                                    SecondName = (string)reader["SecondName"],
                                    ThirdName = reader["ThirdName"] == DBNull.Value ? "" : (string)reader["ThirdName"],
                                    LastName = (string)reader["LastName"],
                                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                                    Gender = Convert.ToByte(reader["Gender"]),
                                    Phone = (string)reader["Phone"],
                                    Address = (string)reader["Address"],
                                    Email = reader["Email"] == DBNull.Value ? "" : (string)reader["Email"],
                                    ImagePath = reader["ImagePath"] == DBNull.Value ? "" : (string)reader["ImagePath"]
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

            return personDto;
        }

        public static PersonDTO GetPersonByNationalNo(string nationalNo)
        {
            PersonDTO personDto = null;
            string query = @"SELECT * FROM People WHERE NationalNo = @NationalNo";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", nationalNo);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                personDto = new PersonDTO
                                {
                                    PersonId = (int)reader["PersonID"],
                                    NationalNo = (string)reader["NationalNo"],
                                    FirstName = (string)reader["FirstName"],
                                    SecondName = (string)reader["SecondName"],
                                    ThirdName = reader["ThirdName"] == DBNull.Value ? "" : (string)reader["ThirdName"],
                                    LastName = (string)reader["LastName"],
                                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                                    Gender = Convert.ToByte(reader["Gender"]),
                                    Phone = (string)reader["Phone"],
                                    Address = (string)reader["Address"],
                                    Email = reader["Email"] == DBNull.Value ? "" : (string)reader["Email"],
                                    ImagePath = reader["ImagePath"] == DBNull.Value ? "" : (string)reader["ImagePath"]
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

            return personDto;
        }

        public static bool DoesPersonExist(string nationalNo)
        {
            bool personExists = false;
            string query = @"SELECT 1 FROM People WHERE NationalNo = @NationalNo";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", nationalNo);
                        object result = command.ExecuteScalar();
                        if (result != null)
                            personExists = true;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return personExists;
        }

        public static int CreatePerson(PersonDTO personDto)
        {
            int personId = -1;
            string query = @"INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Phone,
                              Address, Email, ImagePath)
                              VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender, @Phone,
                              @Address, @Email, @ImagePath);
                              SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", personDto.NationalNo);
                        command.Parameters.AddWithValue("@FirstName", personDto.FirstName);
                        command.Parameters.AddWithValue("@SecondName", personDto.SecondName);
                        command.Parameters.AddWithValue("@ThirdName", string.IsNullOrEmpty(personDto.ThirdName) ? DBNull.Value : (object)personDto.ThirdName);
                        command.Parameters.AddWithValue("@LastName", personDto.LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", personDto.DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", personDto.Gender);
                        command.Parameters.AddWithValue("@Phone", personDto.Phone);
                        command.Parameters.AddWithValue("@Address", personDto.Address);
                        command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(personDto.ImagePath) ? DBNull.Value : (object)personDto.ImagePath);
                        command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(personDto.Email) ? DBNull.Value : (object)personDto.Email);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out personId)) { }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return personId;
        }

        public static bool UpdatePerson(PersonDTO personDto)
        {
            int rowsAffected = 0;
            string query = @"UPDATE People 
                             SET NationalNo = @NationalNo,
                                 FirstName = @FirstName,
                                 SecondName = @SecondName,
                                 ThirdName = @ThirdName,
                                 LastName = @LastName,
                                 DateOfBirth = @DateOfBirth,
                                 Gender = @Gender,
                                 Phone = @Phone,
                                 Address = @Address,
                                 Email = @Email,
                                 ImagePath = @ImagePath
                             WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", personDto.PersonId);
                        command.Parameters.AddWithValue("@NationalNo", personDto.NationalNo);
                        command.Parameters.AddWithValue("@FirstName", personDto.FirstName);
                        command.Parameters.AddWithValue("@SecondName", personDto.SecondName);
                        command.Parameters.AddWithValue("@ThirdName", string.IsNullOrEmpty(personDto.ThirdName) ? DBNull.Value : (object)personDto.ThirdName);
                        command.Parameters.AddWithValue("@LastName", personDto.LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", personDto.DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", personDto.Gender);
                        command.Parameters.AddWithValue("@Phone", personDto.Phone);
                        command.Parameters.AddWithValue("@Address", personDto.Address);
                        command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(personDto.Email) ? DBNull.Value : (object)personDto.Email);
                        command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(personDto.ImagePath) ? DBNull.Value : (object)personDto.ImagePath);

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

        public static bool DeletePerson(int personId)
        {
            int rowsAffected = 0;
            string query = "DELETE FROM People WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", personId);
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