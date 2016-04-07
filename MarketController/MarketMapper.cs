using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketController
{
    class MarketMapper
    {
        public static MarketModels.Good GoodMap(MarketDbContext.Models.good src, MarketModels.Good dst = null) {
            if (dst == null)
                dst = new MarketModels.Good();

            dst.Id = src.id_good;
            dst.Name = src.name_good;
            dst.Price = src.price;
            return dst;
        }
    }
}
