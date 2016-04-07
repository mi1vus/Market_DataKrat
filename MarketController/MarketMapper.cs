using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketController
{
    class MarketMapper
    {
        public static MarketModels.Good GoodMap(MarketDbContext.Models.good src, MarketModels.Good dst = null) {
            if (src == null)
                return null;

            if (dst == null)
                dst = new MarketModels.Good();

            dst.Id = src.id_good;
            dst.Name = src.name_good;
            dst.Price = src.price;
            return dst;
        }

        public static MarketDbContext.Models.check_head CheckMap(MarketModels.Check src, MarketDbContext.Models.check_head dst = null)
        {
            if (src == null)
                return null;

            if (dst == null)
                dst = new MarketDbContext.Models.check_head();

            dst.id_check = src.Id;
            dst.datetime = DateTime.Now;
            dst.summ = src.Summ;
            dst.direction = src.Direction;

            return dst;
        }

        public static MarketDbContext.Models.check_pos CheckItemMap(MarketModels.CheckItem src, MarketDbContext.Models.check_pos dst = null)
        {
            if (src == null)
                return null;

            if (dst == null)
                dst = new MarketDbContext.Models.check_pos();

            dst.num_pos = src.Num;
            dst.id_good = src.GoodId;
            dst.quant = src.Quantity;
            dst.summ_pos = src.SummItem;

            return dst;
        }

        public static MarketModels.ReportItem ReportItemMap(MarketDbContext.Models.reportView src, MarketModels.ReportItem dst = null)
        {
            if (src == null)
                return null;

            if (dst == null)
                dst = new MarketModels.ReportItem();

            dst.Date = src.dateBuy == null ? src.dateReturn.Value : src.dateBuy.Value;
            dst.SummBuy = src.summBuy == null ? 0: src.summBuy.Value;
            dst.SummReturn = src.summReturn == null ? 0 : src.summReturn.Value;
            return dst;
        }
    
    }
}
