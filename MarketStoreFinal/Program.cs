using System;

namespace MarketStoreFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer bronzeCustomer = new Customer
            {
                PurchaseValue = 150.00,
                Turnover = 0,
                Card = new BronzeCard()
            };
            Customer silverCustomer = new Customer
            {
                PurchaseValue = 850.00,
                Turnover = 600.00,
                Card = new SilverCard()
            };
            Customer goldCustomer = new Customer
            {
                PurchaseValue = 1300.00,
                Turnover = 1500.00,
                Card = new GoldCard()
            };

            try
            {
                GetInfo(silverCustomer);
                GetInfo(bronzeCustomer);
                GetInfo(goldCustomer);
            }
            catch (Exception)
            {
                Console.WriteLine($"Input cannot be negative number");
            }
         }

        static void ValidateCustomer(Customer customer)
        {
            if (customer.Turnover < 0 || customer.PurchaseValue < 0)
            {
                throw new Exception("Input cannot be invalid number");
            }
        }

        static void GetInfo(Customer client)
        {
            ValidateCustomer(client);

            Console.WriteLine($"{client.Card}:");
            Console.WriteLine($"Purchase value:{client.PurchaseValue:f2}$");
            Console.WriteLine($"Discount rate:{client.GetDiscountRate():f1}%");
            Console.WriteLine($"Discount:{client.GetDiscount():f2}$");
            Console.WriteLine($"Total:{client.GetTotal():f2}$");
            Console.WriteLine();
        }
    }
}
