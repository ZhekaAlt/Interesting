using Refactoring.Products.Base;

namespace Refactoring.Products
{
    public class ProductPerWeight : Product
    {
        decimal? Weight;

        public ProductPerWeight(
            string productName,
            decimal price,
            decimal weight) : base(productName, price)
        {
            Weight = weight;
        }

        public override decimal GetPrice()
        {
            return Weight.GetValueOrDefault() * Price;
        }

        protected override string ProductDetails => $"{Weight.GetValueOrDefault()} pounds at ${Price} per pound";
    }
}