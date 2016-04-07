using System;
using System.Collections.Generic;

namespace MarketDbContext.Models
{
    public partial class reportView
    {
        public Nullable<DateTime> dateBuy { get; set; }
        public Nullable<DateTime> dateReturn { get; set; }
        public Nullable<decimal> summBuy { get; set; }
        public Nullable<decimal> summReturn { get; set; }
    }
}
