using System.Linq;
using System.Text;

namespace Refactoring.Orders.Extensions
{
    public static class OrderExtensions
    {
        public static string GetOrderSummary(this Order order)
        {
            var orderSummary = new StringBuilder();
            orderSummary.AppendLine($"ORDER SUMMARY FOR {order.CustomerName}:");

            foreach (var orderProduct in order.Products)
            {
                orderSummary.AppendLine(orderProduct.GetProductSummary());
            }

            orderSummary.AppendLine();
            var totalOrderPrice = order.Products
                .Select(product => product.GetPrice())
                .Sum();

            orderSummary.Append($"Total Price: ${totalOrderPrice}");
            return orderSummary.ToString();
        }
    }
}