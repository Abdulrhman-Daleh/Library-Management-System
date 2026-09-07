using DataAccess.DTOs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class UserData
    {
        private static readonly string _sourceName = "UserData";

        public static async Task<DataTable> GetAllUsersAsync()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT users.UserID, p.PersonID, Username, IsActive, LastLoginDate
                             FROM Users
                             INNER JOIN People AS p ON p.PersonID = Users.PersonID";

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

        public static async Task<DataTable> GetUsersByUserIdAsync(int userId)
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT Users.UserID, m.MemberID, p.PersonID, Username, IsActive, LastLoginDate
                             FROM Users
                             INNER JOIN People AS p ON p.PersonID = Users.PersonID
                             inner Join Members as m on m.UserID = Users.UserID
                             WHERE Users.UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
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

        public static async Task<DataTable> GetAllUsersAsyncInType(int membershipTypeId)
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT users.UserID, p.PersonID, Username, IsActive, LastLoginDate
                             FROM Users
                             INNER JOIN People AS p ON p.PersonID = Users.PersonID
                             inner join Members as m on m.UserID = Users.UserID
                             inner join MembershipType as mship on mship.MembershipTypeID = m.MembershipTypeID
                             where mship.MembershipTypeID = @MembershipTypeID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MembershipTypeID", membershipTypeId);

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

        public static async Task<DataTable> GetAllUsersAsyncInTypeAndUser(int membershipTypeId, int userId)
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT users.UserID, p.PersonID, Username, IsActive, LastLoginDate
                             FROM Users
                             INNER JOIN People AS p ON p.PersonID = Users.PersonID
                             inner join Members as m on m.UserID = Users.UserID
                             inner join MembershipType as mship on mship.MembershipTypeID = m.MembershipTypeID
                             where mship.MembershipTypeID = @MembershipTypeID and Users.UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MembershipTypeID", membershipTypeId);
                        command.Parameters.AddWithValue("@UserID", userId);

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

        public static int CreateUser(UserDTO userDto)
        {
            int userId = -1;
            string query = @"INSERT INTO Users (PersonID, Username, HashedPassword, FailedLoginAttempts,
                              IsActive, AccountLockExpirationDate, LastLoginDate, LastPasswordChangeDate, Permission)
                              VALUES (@PersonID, @Username, @HashedPassword, @FailedLoginAttempts, @IsActive,
                              @AccountLockExpirationDate, @LastLoginDate, @LastPasswordChangeDate, @Permission);
                              SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", userDto.PersonId);
                        command.Parameters.AddWithValue("@Username", userDto.Username);
                        command.Parameters.AddWithValue("@HashedPassword", userDto.HashedPassword);
                        command.Parameters.AddWithValue("@IsActive", userDto.IsActive);
                        command.Parameters.AddWithValue("@Permission", userDto.Permission);

                        command.Parameters.AddWithValue("@FailedLoginAttempts", (object)userDto.FailedLoginAttempts ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AccountLockExpirationDate", (object)userDto.AccountLockExpirationDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastLoginDate", (object)userDto.LastLoginDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastPasswordChangeDate", (object)userDto.LastPasswordChangeDate ?? DBNull.Value);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out userId)) { }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return userId;
        }

        public static bool UpdateUser(UserDTO userDto)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Users 
                             SET PersonID = @PersonID,
                                 Username = @Username,
                                 HashedPassword = @HashedPassword,
                                 IsActive = @IsActive,
                                 FailedLoginAttempts = @FailedLoginAttempts,
                                 AccountLockExpirationDate = @AccountLockExpirationDate,
                                 LastLoginDate = @LastLoginDate,
                                 LastPasswordChangeDate = @LastPasswordChangeDate,
                                 Permission = @Permissions
                             WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userDto.UserId);
                        command.Parameters.AddWithValue("@PersonID", userDto.PersonId);
                        command.Parameters.AddWithValue("@Username", userDto.Username);
                        command.Parameters.AddWithValue("@HashedPassword", userDto.HashedPassword);
                        command.Parameters.AddWithValue("@IsActive", userDto.IsActive);
                        command.Parameters.AddWithValue("@Permissions", userDto.Permission);

                        command.Parameters.AddWithValue("@FailedLoginAttempts", (object)userDto.FailedLoginAttempts ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AccountLockExpirationDate", (object)userDto.AccountLockExpirationDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastLoginDate", (object)userDto.LastLoginDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastPasswordChangeDate", (object)userDto.LastPasswordChangeDate ?? DBNull.Value);

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

        public static UserDTO GetUserById(int userId)
        {
            UserDTO userDto = null;
            string query = @"SELECT TOP 1 * FROM Users WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userDto = new UserDTO
                                {
                                    UserId = (int)reader["UserID"],
                                    PersonId = (int)reader["PersonID"],
                                    Username = (string)reader["Username"],
                                    HashedPassword = (string)reader["HashedPassword"],
                                    IsActive = (bool)reader["IsActive"],
                                    Permission = (int)reader["Permission"],
                                    FailedLoginAttempts = reader["FailedLoginAttempts"] == DBNull.Value ? null : (int?)reader["FailedLoginAttempts"],
                                    AccountLockExpirationDate = reader["AccountLockExpirationDate"] == DBNull.Value ? null : (DateTime?)reader["AccountLockExpirationDate"],
                                    LastLoginDate = reader["LastLoginDate"] == DBNull.Value ? null : (DateTime?)reader["LastLoginDate"],
                                    LastPasswordChangeDate = reader["LastPasswordChangeDate"] == DBNull.Value ? null : (DateTime?)reader["LastPasswordChangeDate"]
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

            return userDto;
        }

        public static bool DeleteUser(int userId)
        {
            int rowsAffected = 0;
            string query = "DELETE FROM Users WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
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

        public static UserDTO GetUserByPersonId(int personId)
        {
            UserDTO userDto = null;
            string query = @"SELECT TOP 1 * FROM Users WHERE PersonID = @PersonID";

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
                                userDto = new UserDTO
                                {
                                    UserId = (int)reader["UserID"],
                                    PersonId = (int)reader["PersonID"],
                                    Username = (string)reader["Username"],
                                    HashedPassword = (string)reader["HashedPassword"],
                                    IsActive = (bool)reader["IsActive"],
                                    Permission = (int)reader["Permission"],
                                    FailedLoginAttempts = reader["FailedLoginAttempts"] == DBNull.Value ? null : (int?)reader["FailedLoginAttempts"],
                                    AccountLockExpirationDate = reader["AccountLockExpirationDate"] == DBNull.Value ? null : (DateTime?)reader["AccountLockExpirationDate"],
                                    LastLoginDate = reader["LastLoginDate"] == DBNull.Value ? null : (DateTime?)reader["LastLoginDate"],
                                    LastPasswordChangeDate = reader["LastPasswordChangeDate"] == DBNull.Value ? null : (DateTime?)reader["LastPasswordChangeDate"]
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

            return userDto;
        }

        public static bool SetUserActiveStatus(int userId, bool isActive)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Users SET IsActive = @IsActive WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@IsActive", isActive);
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

        public static bool UpdateUserPassword(int userId, string newHashedPassword)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Users 
                             SET HashedPassword = @NewPassword,
                                 LastPasswordChangeDate = @LastPasswordChangeDate
                             WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@NewPassword", newHashedPassword);
                        command.Parameters.AddWithValue("@LastPasswordChangeDate", DateTime.Now);

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

        public static UserDTO GetUserByUsername(string username)
        {
            UserDTO userDto = null;
            string query = @"SELECT TOP 1 * FROM Users WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userDto = new UserDTO
                                {
                                    UserId = (int)reader["UserID"],
                                    PersonId = (int)reader["PersonID"],
                                    Username = (string)reader["Username"],
                                    HashedPassword = (string)reader["HashedPassword"],
                                    IsActive = (bool)reader["IsActive"],
                                    Permission = (int)reader["Permission"],
                                    FailedLoginAttempts = reader["FailedLoginAttempts"] == DBNull.Value ? null : (int?)reader["FailedLoginAttempts"],
                                    AccountLockExpirationDate = reader["AccountLockExpirationDate"] == DBNull.Value ? null : (DateTime?)reader["AccountLockExpirationDate"],
                                    LastLoginDate = reader["LastLoginDate"] == DBNull.Value ? null : (DateTime?)reader["LastLoginDate"],
                                    LastPasswordChangeDate = reader["LastPasswordChangeDate"] == DBNull.Value ? null : (DateTime?)reader["LastPasswordChangeDate"]
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

            return userDto;
        }

        public static bool UpdateFailedLoginAttempts(int userId, int? loginAttempts)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Users SET FailedLoginAttempts = @FailedLoginAttempts WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@FailedLoginAttempts", loginAttempts ?? (object)DBNull.Value);
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

        public static bool UpdateAccountLockExpirationDate(int userId, DateTime? lockExpirationDate)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Users SET AccountLockExpirationDate = @LockDate WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@LockDate", lockExpirationDate ?? (object)DBNull.Value);
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

        public static bool ClearFailedLoginAttempts(int userId)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Users SET FailedLoginAttempts = @NewLoginAttempt WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@NewLoginAttempt", DBNull.Value);
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

        public static bool IsUserAMember(int userId)
        {
            bool isMember = false;
            string query = @"SELECT 1 FROM Users 
                             INNER JOIN Members ON Users.UserID = Members.UserID 
                             WHERE Users.UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        object result = command.ExecuteScalar();
                        if (result != null)
                            isMember = true;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return isMember;
        }
    }
}