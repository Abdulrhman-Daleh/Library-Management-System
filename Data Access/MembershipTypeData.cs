using DataAccess.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class MembershipTypeData
    {
        private static readonly string _sourceName = "MembershipTypeData";

        public static async Task<DataTable> GetAllMembershipTypesAsync()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM MembershipType ORDER BY MembershipTypeID ASC";

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

        public static List<string> GetAllMembershipTypeNames()
        {
            List<string> membershipTypeNames = new List<string>();
            string query = "SELECT MembershipTypeName FROM MembershipType ORDER BY MembershipTypeID ASC";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            membershipTypeNames.Add(reader.GetValue(0).ToString());
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return membershipTypeNames;
        }

        public static int CreateMembershipType(MembershipTypeDTO membershipTypeDto)
        {
            int membershipTypeId = -1;
            string query = @"INSERT INTO MembershipType (MembershipTypeName, MembershipFees, MembershipBorrowLimit)
                             VALUES (@MembershipTypeName, @MembershipFees, @MembershipBorrowLimit);
                             SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MembershipTypeName", membershipTypeDto.MembershipTypeName);
                        command.Parameters.AddWithValue("@MembershipFees", membershipTypeDto.MembershipFees);
                        command.Parameters.AddWithValue("@MembershipBorrowLimit", membershipTypeDto.MembershipBorrowLimit);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out membershipTypeId)) { }
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return membershipTypeId;
        }

        public static bool UpdateMembershipType(MembershipTypeDTO membershipTypeDto)
        {
            int rowsAffected = 0;
            string query = @"UPDATE MembershipType 
                             SET MembershipTypeName = @MembershipTypeName,
                                 MembershipFees = @MembershipFees,
                                 MembershipBorrowLimit = @MembershipBorrowLimit
                             WHERE MembershipTypeID = @MembershipTypeID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MembershipTypeID", membershipTypeDto.MembershipTypeId);
                        command.Parameters.AddWithValue("@MembershipTypeName", membershipTypeDto.MembershipTypeName);
                        command.Parameters.AddWithValue("@MembershipFees", membershipTypeDto.MembershipFees);
                        command.Parameters.AddWithValue("@MembershipBorrowLimit", membershipTypeDto.MembershipBorrowLimit);

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

        public static bool DeleteMembershipType(int membershipTypeId)
        {
            int rowsAffected = 0;
            string query = "DELETE FROM MembershipType WHERE MembershipTypeID = @MembershipTypeID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MembershipTypeID", membershipTypeId);
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

        public static MembershipTypeDTO GetMembershipTypeById(int membershipTypeId)
        {
            MembershipTypeDTO membershipTypeDto = null;
            string query = @"SELECT * FROM MembershipType WHERE MembershipTypeID = @MembershipTypeID";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MembershipTypeID", membershipTypeId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                membershipTypeDto = new MembershipTypeDTO
                                {
                                    MembershipTypeId = (int)reader["MembershipTypeID"],
                                    MembershipTypeName = (string)reader["MembershipTypeName"],
                                    MembershipFees = Convert.ToSingle(reader["MembershipFees"]),
                                    MembershipBorrowLimit = reader["MembershipBorrowLimit"] != DBNull.Value ? (int)reader["MembershipBorrowLimit"] : -1
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

            return membershipTypeDto;
        }

        public static MembershipTypeDTO GetMembershipTypeByName(string membershipTypeName)
        {
            MembershipTypeDTO membershipTypeDto = null;
            string query = @"SELECT * FROM MembershipType WHERE MembershipTypeName = @MembershipTypeName";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MembershipTypeName", membershipTypeName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                membershipTypeDto = new MembershipTypeDTO
                                {
                                    MembershipTypeId = (int)reader["MembershipTypeID"],
                                    MembershipTypeName = (string)reader["MembershipTypeName"],
                                    MembershipFees = Convert.ToSingle(reader["MembershipFees"]),
                                    MembershipBorrowLimit = reader["MembershipBorrowLimit"] != DBNull.Value ? (int)reader["MembershipBorrowLimit"] : -1
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

            return membershipTypeDto;
        }

        public static int GetAllMembersCountInType(int membershipTypeId)
        {
            int count = 0;

            string query = @"select count(*) from MembershipType as mtype
                    inner join Members as m on m.MembershipTypeID = mtype.MembershipTypeID
                    where mtype.MembershipTypeID = @MembershipTypeID;";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MembershipTypeID", membershipTypeId);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out count)) ;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return count;
        }

        public static int GetAllBorrowedCountInType(int membershipTypeId)
        {
            int count = 0;

            string query = @"select count(*) from MembershipType as mtype
                    inner join Members as m on m.MembershipTypeID = mtype.MembershipTypeID
                    inner join BorrowTransactions as borrowT on borrowT.MemberID = m.MemberID
                    inner join BorrowStatus as borrowS on borrowS.BorrowStatusID = borrowT.BorrowStatusID
                    where BorrowS.BorrowStatusTitle = 'Borrow' and mtype.MembershipTypeID = @MembershipTypeID;";

            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MembershipTypeID", membershipTypeId);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out count)) ;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return count;
        }

        public static decimal GetFinesAmountInType(int membershipTypeId)
        {
          decimal amount = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionAccess.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_getTotalMembershipTypeFees", connection))
                    {
                        command.Parameters.AddWithValue("@MembershipTypeID", membershipTypeId);

                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter parameter = new SqlParameter("@FinesAmount", SqlDbType.Decimal)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(parameter);
                        command.ExecuteNonQuery();

                        amount = (decimal)command.Parameters["@FinesAmount"].Value;
                    }
                }
                catch (Exception ex)
                {
                    DataLogger.LogError(_sourceName, ex.Message);
                }
            }

            return amount;
        }

    }

}