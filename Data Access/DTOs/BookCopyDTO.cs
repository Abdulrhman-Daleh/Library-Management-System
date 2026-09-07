using System;

namespace DataAccess.DTOs
{
    public class BookCopyDTO
    {
        public int BookCopyId { get; set; }
        public int BookId { get; set; }
        public byte StatusId { get; set; }
        public byte ConditionId { get; set; }
        public DateTime AddedDate { get; set; }
        public decimal BookCopyPrice { get; set; }
    }
}