using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketModels
{
    public class CheckItem
    {
        public int Num { get; set; }
        public int CheckId { get; set; }
        public double Quantity { get; set; }
        public decimal SummItem { get; set; }
        public int GoodId { get; set; }
        public string GoodName { get; set; }
    }
}
