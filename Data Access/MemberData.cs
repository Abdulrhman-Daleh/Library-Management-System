using DataAccess.DTOs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class MemberData
    {
        private static readonly string _sourceName = "MemberData";

        public static int CreateMember(MemberDTO memberDto)
        {
            int memberId = -1;
            string query = @"INSERT INTO Members (MemberJoinDate, UserID, MembershipTypeID, MembershipExpirationDate)
                             VALUES (@MemberJoinDate, @UserID, @MembershipTypeID, @MembershipExpirationDate);
                             SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberJoinDate", memberDto.MemberJoinDate);
                        command.Parameters.AddWithValue("@UserID", memberDto.UserId);
                        command.Parameters.AddWithValue("@MembershipTypeID", memberDto.MembershipTypeId);
                        command.Parameters.AddWithValue("@MembershipExpirationDate", memberDto.MembershipExpirationDate);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out memberId)) { }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return memberId;
        }

        public static bool UpdateMember(MemberDTO memberDto)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateMemberMembership", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MemberID", memberDto.MemberId);
                        command.Parameters.AddWithValue("@MembershipTypeID", memberDto.MembershipTypeId);

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

        public static MemberDTO GetMemberById(int memberId)
        {
            MemberDTO memberDto = null;
            string query = @"SELECT TOP 1 * FROM Members WHERE MemberID = @MemberID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", memberId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                memberDto = new MemberDTO
                                {
                                    MemberId = (int)reader["MemberID"],
                                    UserId = (int)reader["UserID"],
                                    MemberJoinDate = (DateTime)reader["MemberJoinDate"],
                                    MembershipTypeId = (int)reader["MembershipTypeID"],
                                    MembershipExpirationDate = (DateTime)reader["MembershipExpirationDate"]
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

            return memberDto;
        }

        public static bool DeleteMember(int memberId)
        {
            int rowsAffected = 0;
            string query = "DELETE FROM Members WHERE MemberID = @MemberID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", memberId);
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                    throw new Exception("Member cannot be deleted because it is linked to other data", ex.InnerException);
                }
            }

            return rowsAffected > 0;
        }

        public static async Task<DataTable> GetAllMembersAsync()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT MemberID, UserID, MemberJoinDate, MembershipTypeID, MembershipExpirationDate FROM Members";

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

        public static async Task<DataTable> GetAllMembersByUserIdAsync(int userId)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT MemberID, UserID, MemberJoinDate, MembershipTypeID, MembershipExpirationDate FROM Members WHERE UserID = @UserID";

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

        public static MemberDTO GetMemberByUserId(int userId)
        {
            MemberDTO memberDto = null;
            string query = @"SELECT TOP 1 * FROM Members WHERE UserID = @UserID";

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
                                memberDto = new MemberDTO
                                {
                                    MemberId = (int)reader["MemberID"],
                                    UserId = (int)reader["UserID"],
                                    MemberJoinDate = (DateTime)reader["MemberJoinDate"],
                                    MembershipTypeId = (int)reader["MembershipTypeID"],
                                    MembershipExpirationDate = (DateTime)reader["MembershipExpirationDate"]
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

            return memberDto;
        }

        public static bool IsMembershipExpired(int memberId)
        {
            bool isExpired = false;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_IsMembershipExpired", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MemberID", memberId);

                        SqlParameter expiredParam = new SqlParameter("@Expired", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(expiredParam);
                        command.ExecuteNonQuery();

                        isExpired = (bool)expiredParam.Value;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return isExpired;
        }

        public static bool HasReachedBorrowLimit(int memberId)
        {
            bool hasReachedLimit = false;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_HasReachedBorrowLimit", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MemberID", memberId);

                        SqlParameter limitParam = new SqlParameter("@LimitReached", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(limitParam);
                        command.ExecuteNonQuery();

                        hasReachedLimit = (bool)limitParam.Value;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return hasReachedLimit;
        }

        public static bool HasGeneralFees(int memberId)
        {
            bool hasGeneralFees = false;

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_HasGeneralFees", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MemberID", memberId);

                        SqlParameter hasFeesParam = new SqlParameter("@hasGeneralFees", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(hasFeesParam);
                        command.ExecuteNonQuery();

                        hasGeneralFees = (bool)command.Parameters["@hasGeneralFees"].Value;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return hasGeneralFees;
        }

        public static int GetMemberIDByUserID(int userId)
        {
            MemberDTO memberDto = null;
            string query = @"SELECT MemberID FROM Members WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                            object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int memberId))
                            return memberId;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return -1;
        }

        public static bool HasBorrowHistory(int memberId)
        {
            bool hasHistory = false;
            string query = @"SELECT TOP 1 1 FROM BorrowTransactions WHERE MemberID = @MemberID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", memberId);
                       object result =  command.ExecuteScalar();

                        return result != null;

                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return false;
        }

        public static MemberDTO FindMemberByPaymentID(int paymentId)
        {
            MemberDTO memberDto = null;
            string query = @"select top 1
            	m.*
            from BorrowTransactions as bt
            
            	inner join Fines as f on bt.BorrowID = f.BorrowID
            
            	inner join FinePayments as fp on fp.FineID = f.FineID
            
            	inner join Members as m on m.MemberID = bt.MemberID
            	where fp.PaymentID = @PaymentID;";

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
                                memberDto = new MemberDTO
                                {
                                    MemberId = (int)reader["MemberID"],
                                    UserId = (int)reader["UserID"],
                                    MemberJoinDate = (DateTime)reader["MemberJoinDate"],
                                    MembershipTypeId = (int)reader["MembershipTypeID"],
                                    MembershipExpirationDate = (DateTime)reader["MembershipExpirationDate"]
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

            return memberDto;
        }
    }
}