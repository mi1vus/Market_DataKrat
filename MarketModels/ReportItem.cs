using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketModels
{
    /// <summary>
    /// Данные за день в отчете
    /// </summary>
    public class ReportItem
    {
        public DateTime Date { get; set; }
        public string DateString { 
            get {
                return Date.ToString("dd.MM.yyyy");
            } 
        }

        public decimal SummBuy { get; set; }
        public string SummBuyString
        {
            get
            {
                return SummBuy.ToString("0,000.00");
            }
        }

        public decimal SummReturn { get; set; }
        public string SummReturnString
        {
            get
            {
                return "-" + SummReturn.ToString("0,000.00");
            }
        }

        public decimal CommonSumm
        {
            get
            {
                return SummBuy - SummReturn;
            }
        }
        public string CommonSummString
        {
            get
            {
                return CommonSumm.ToString("0,000.00");
            }
        }
    }
}
