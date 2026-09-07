using System;

namespace DataAccess.DTOs
{
    public class BorrowTransactionDTO
    {
        public int BorrowId { get; set; }
        public int BookCopyId { get; set; }
        public int MemberId { get; set; }
        public int BorrowStatusId { get; set; }
        public int PolicyId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? LostDate { get; set; }
    }
}