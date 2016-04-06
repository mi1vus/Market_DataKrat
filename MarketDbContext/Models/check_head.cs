using System;
using System.Collections.Generic;

namespace MarketDbContext.Models
{
    public partial class check_head
    {
        public check_head()
        {
            this.check_pos = new List<check_pos>();
        }

        public int id_check { get; set; }
        public int number { get; set; }
        public System.DateTime datetime { get; set; }
        public decimal summ { get; set; }
        public int direction { get; set; }
        public virtual ICollection<check_pos> check_pos { get; set; }
    }
}
