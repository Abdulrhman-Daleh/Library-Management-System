using System;

namespace DataAccess.DTOs
{
    public class MembershipTypeDTO
    {
        public int MembershipTypeId { get; set; }
        public string MembershipTypeName { get; set; }
        public float MembershipFees { get; set; }
        public int MembershipBorrowLimit { get; set; }
    }
}