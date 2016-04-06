using System;
using System.Collections.Generic;

namespace MarketDbContext.Models
{
    public partial class good
    {
        public good()
        {
            this.barcodes = new List<barcode>();
            this.check_pos = new List<check_pos>();
        }

        public string name_good { get; set; }
        public int id_good { get; set; }
        public Nullable<double> NDS { get; set; }
        public Nullable<double> NSP { get; set; }
        public string BarCodeDefault { get; set; }
        public Nullable<int> id_country { get; set; }
        public Nullable<int> id_producer { get; set; }
        public Nullable<int> id_measure { get; set; }
        public string articul { get; set; }
        public decimal price { get; set; }
        public Nullable<int> unused { get; set; }
        public Nullable<int> plu { get; set; }
        public Nullable<decimal> min_price { get; set; }
        public Nullable<System.DateTime> last_change { get; set; }
        public Nullable<int> id_user_change { get; set; }
        public string short_name_good { get; set; }
        public Nullable<int> id_type_good { get; set; }
        public int remains_rule { get; set; }
        public virtual ICollection<barcode> barcodes { get; set; }
        public virtual ICollection<check_pos> check_pos { get; set; }
    }
}
