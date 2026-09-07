using System;

namespace DataAccess.DTOs
{
    public class MemberDTO
    {
        public int MemberId { get; set; }
        public DateTime MemberJoinDate { get; set; }
        public int UserId { get; set; }
        public int MembershipTypeId { get; set; }
        public DateTime MembershipExpirationDate { get; set; }
    }
}