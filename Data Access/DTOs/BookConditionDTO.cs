using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.DTOs
{
    public class BookConditionDTO
    {
        public int ConditionId { get; set; }
        public decimal ConditionFees { get; set; }
        public string ConditionTitle { get; set; }
    }
}
