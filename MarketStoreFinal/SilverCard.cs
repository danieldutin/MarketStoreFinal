using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStoreFinal
{
    public class SilverCard : ICard
    {
        public double CalculateDiscountRate(Customer customer)
        {
            double discountRate = 0;

            if (customer.Turnover > 300)
            {
                discountRate = 3.5;
            }
            else
            {
                discountRate = 2;
            }

            return discountRate;
        }
        public double CalculateDiscount(Customer customer)
        {
            double discountRate = CalculateDiscountRate(customer);
            double discount = customer.PurchaseValue * discountRate / 100;
            return discount;
        }
        public double CalculateTotal(Customer customer)
        {
            double discount = CalculateDiscount(customer);
            double total = customer.PurchaseValue - discount;
            return total;
        }
    }
}
