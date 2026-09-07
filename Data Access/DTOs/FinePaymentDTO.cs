using System;

namespace DataAccess.DTOs
{
    public class FinePaymentDTO
    {
        public int PaymentId { get; set; }
        public int FineId { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
    }
}