using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMModels.Models
{
    public class BillModel :CommonModel
    {
        public string BillType { get; set; } //Electric, Gas, Internet
        public decimal Amount { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public bool IsPaid { get; set; }
    }
}
