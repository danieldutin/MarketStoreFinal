using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStoreFinal
{
    public class Customer
    {
        public ICard Card { get; set; }
        public double PurchaseValue { get; set; }
        public double Turnover { get; set; }

        public double GetDiscount()
        {
            return Card.CalculateDiscount(this);
        }

        public double GetDiscountRate()
        {
            return Card.CalculateDiscountRate(this);
        }

        public double GetTotal()
        {
            return Card.CalculateTotal(this);
        }
    }
}
