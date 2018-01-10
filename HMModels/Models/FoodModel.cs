using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMModels.Models
{
    public class FoodModel : CommonModel
    {
        public string FoodName { get; set; }
        public DateTime BuyDate { get; set; }
        public DateTime BestBeforeDate { get; set; }
        public DateTime ConsumedDate { get; set; }
    }
}
