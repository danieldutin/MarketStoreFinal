using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStoreFinal
{
    public interface ICard
    {
        public double CalculateDiscount(Customer customer);
        public double CalculateDiscountRate(Customer customer);
        public double CalculateTotal(Customer customer);
    }
}
