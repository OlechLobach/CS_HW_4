using System;
using MoneyNamespace;
using ProductNamespace;

namespace ProductApp
{
    class Program
    {
        static void Main()
        {
            Money money = new Money(10, 50);
            money.DisplayAmount();

            Product product = new Product("Laptop", 1500, 0);
            product.DisplayPrice();

            product.DecreasePrice(100, 50);
            product.DisplayPrice();
        }
    }
}