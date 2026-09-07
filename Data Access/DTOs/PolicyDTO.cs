using System;

namespace DataAccess.DTOs
{
    public class PolicyDTO
    {
        public int PolicyId { get; set; }
        public decimal FeesPerLateDay { get; set; }
        public int GracePeriodDays { get; set; }
        public decimal LostBookFeeMultiplier { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }

    }
}