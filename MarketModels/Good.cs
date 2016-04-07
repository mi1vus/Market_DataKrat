using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketModels
{
    public class Good
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string PriceText { 
            get {
                return Price.ToString("0.00");
            } 
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
