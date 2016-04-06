using System;
using System.Collections.Generic;

namespace MarketDbContext.Models
{
    public partial class barcode
    {
        public int id_bar_code { get; set; }
        public Nullable<double> bar_code_quantity { get; set; }
        public string bar_code { get; set; }
        public Nullable<decimal> bar_code_price { get; set; }
        public Nullable<int> id_good { get; set; }
        public Nullable<int> Unused { get; set; }
        public Nullable<int> ask_quantity { get; set; }
        public Nullable<int> ask_serial { get; set; }
        public virtual good good { get; set; }
    }
}
