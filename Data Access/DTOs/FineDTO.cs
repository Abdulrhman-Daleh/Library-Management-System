using System;

namespace DataAccess.DTOs
{
    public class FineDTO
    {
        public int FineId { get; set; }
        public int? BorrowId { get; set; }
        public int FineStatusId { get; set; }
        public decimal FineAmount { get; set; }
        public string Reason { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? RenewId { get; set; }
    }
}