using System;

namespace DataAccess.DTOs
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public int PersonId { get; set; }
        public string Username { get; set; }
        public string HashedPassword { get; set; }
        public bool IsActive { get; set; }
        public int? FailedLoginAttempts { get; set; }
        public DateTime? AccountLockExpirationDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? LastPasswordChangeDate { get; set; }
        public int Permission { get; set; }
    }
}