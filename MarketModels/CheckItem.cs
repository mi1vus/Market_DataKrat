using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketModels
{
    public class CheckItem
    {
        public int Num { get; set; }
        private double PrivateQuantity { get; set; }
        public double Quantity { 
            get{
                return PrivateQuantity;
            } 
            set{
                PrivateQuantity = value;
                if (Good != null){
                    SummItem = Convert.ToDecimal(PrivateQuantity) * Good.Price;
                    if (OnSummChanged != null)
                        OnSummChanged(this, EventArgs.Empty);
                }
            } 
        }
        public decimal SummItem { get; set; }
        public int GoodId { get; set; }
        public Good Good { get; set; }

        public static event EventHandler OnSummChanged;
    }
}
