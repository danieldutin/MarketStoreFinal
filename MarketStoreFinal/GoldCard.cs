using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStoreFinal
{
    public class GoldCard : ICard
    {
        public double CalculateDiscountRate(Customer customer)
        {
            double discountRate = 0;

            if (customer.Turnover < 100)
            {
                discountRate = 2;
            }
            else
            {
                double currentDiscountBonus = (Math.Floor(customer.Turnover / 100));
                if (currentDiscountBonus > 9)
                {
                    currentDiscountBonus = 9;
                }

                discountRate = currentDiscountBonus + 1;

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
