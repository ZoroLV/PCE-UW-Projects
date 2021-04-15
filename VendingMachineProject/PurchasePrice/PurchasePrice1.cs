// Excercise 03
//Author: Jensen, Luke

using System;

namespace Exercise03
{
    public class PurchasePrice
    {
        private decimal price = 0M;

        public PurchasePrice()
        {
            price = 0M;
        }
        
        [Obsolete("Use the decimal version of this constructor instead", false)]
        public PurchasePrice(int initialPrice)
        {
            price = initialPrice;
        }

        public PurchasePrice(decimal initialPrice)
        {
            priceDecimal = initialPrice;
        }

        [Obsolete("Use the decimal version of this constructor instead", false)]
        public int Price
        {
            get
            {
                return (int)(price * 100);
            }
            set
            {
                price = value / 100M;
            }
        }

        public decimal priceDecimal
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
