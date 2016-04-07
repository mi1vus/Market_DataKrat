using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketModels
{
    /// <summary>
    /// Позиция в чеке
    /// </summary>
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
                    // пересчитываем цену всей позиции
                    SummItem = Convert.ToDecimal(PrivateQuantity) * Good.Price;
                    if (OnSummChanged != null)
                        // генерируем событие для пересчета суммы всего чека
                        OnSummChanged(this, null);
                }
            } 
        }
        public decimal SummItem { get; private set; }
        public int GoodId { get; set; }
        public Good Good { get; set; }

        /// <summary>
        /// Событие которое будет вызвано при изменении количества товара
        /// для автоматического пересчета суммы всего чека
        /// </summary>
        public event System.Collections.Specialized.NotifyCollectionChangedEventHandler OnSummChanged;
    }
}
