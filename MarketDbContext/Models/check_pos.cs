using System;
using System.Collections.Generic;

namespace MarketDbContext.Models
{
    public partial class check_pos
    {
        public int num_pos { get; set; }
        public int id_check { get; set; }
        public double quant { get; set; }
        public decimal summ_pos { get; set; }
        public int id_good { get; set; }
        public virtual check_head check_head { get; set; }
        public virtual good good { get; set; }
    }
}
