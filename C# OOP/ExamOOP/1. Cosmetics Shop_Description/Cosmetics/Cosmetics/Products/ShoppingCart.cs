namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Linq;

    using Cosmetics.Contracts;

    public class ShoppingCart: IShoppingCart
    {
        private ICollection<IProduct> cartOfProducts;

        public ShoppingCart()
        {
            this.cartOfProducts = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            Extensions.Validator.CheckForNullOrEmpty(product);
            this.cartOfProducts.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            Extensions.Validator.CheckForNullOrEmpty(product);
            this.cartOfProducts.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
           return this.cartOfProducts.Contains(product);
        }

        public decimal TotalPrice()
        {
            return this.cartOfProducts.Sum(x => x.Price);

        }
    }
}
