using System;
using Refactoring.Orders;
using Refactoring.Orders.Extensions;
using Refactoring.Products;

namespace Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = Order.Create("John Doe",
                new ProductPerWeight("Pulled Pork", 6.99m, 0.5m),
                    new ProductPerItem("Coke", 3m, 2)
            );

            Console.WriteLine(order.GetOrderSummary());

            Console.ReadKey();
        }
    }
}

