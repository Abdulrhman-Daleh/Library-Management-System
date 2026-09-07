using System;

namespace DataAccess.DTOs
{
    public class MembershipRenewDTO
    {
        public int RenewId { get; set; }
        public int MemberId { get; set; }
        public int MembershipTypeId { get; set; }
        public DateTime RenewDate { get; set; }
        public decimal RenewFees { get; set; }
        public bool IsPaid { get; set; }
    }
}