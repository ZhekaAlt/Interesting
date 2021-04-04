namespace Refactoring.Products.Base
{
    public abstract class Product
    {
        string ProductName;
        protected decimal Price;

        protected Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }

        public abstract decimal GetPrice();

        public string GetProductSummary()
        {
            return $"{ProductName} ${GetPrice()} ({ProductDetails})";
        }

        protected abstract string ProductDetails { get; }
    }
}