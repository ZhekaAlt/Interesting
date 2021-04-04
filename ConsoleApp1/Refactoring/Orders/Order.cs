using System.Collections.Generic;
using Refactoring.Products;
using Refactoring.Products.Base;

namespace Refactoring.Orders
{
    public class Order
    {
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; }

        public static Order Create(string customerName, params Product[] products)
        {
            return new Order
            {
                CustomerName = customerName,
                Products = new List<Product>(products)
            };
        }
    }
}