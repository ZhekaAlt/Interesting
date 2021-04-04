using Refactoring.Products.Base;

namespace Refactoring.Products
{
    public class ProductPerItem : Product
    {
        int? Quantity;

        public ProductPerItem(
            string productName,
            decimal price,
            int quantity) : base(productName, price)
        {
            Quantity = quantity;
        }

        public override decimal GetPrice()
        {
            return Quantity.GetValueOrDefault() * Price;
        }

        protected override string ProductDetails => $"{Quantity.GetValueOrDefault()} items at ${Price} each";
    }
}