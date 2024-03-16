
using System;
using MoneyNamespace;

namespace ProductNamespace
{
    public class Product
    {
        public string Name { get; }
        public MoneyNamespace.Money Price { get; private set; }

        public Product(string name, int dollars, int cents)
        {
            Name = name;
            Price = new MoneyNamespace.Money(dollars, cents);
        }

        public void DecreasePrice(int dollars, int cents)
        {
            int totalCents = Price.Dollars * 100 + Price.Cents;
            totalCents -= dollars * 100 + cents;

            Price.Dollars = totalCents / 100;
            Price.Cents = totalCents % 100;
        }

        public void DisplayPrice()
        {
            Console.Write($"Price of {Name}: ");
            Price.DisplayAmount();
        }
    }
}