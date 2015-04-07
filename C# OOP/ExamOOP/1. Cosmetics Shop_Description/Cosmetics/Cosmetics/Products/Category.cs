namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Category : ICategory
    {
        private string name;
        private ICollection<IProduct> listOfProducts;

        public Category(string name)
        {
            this.Name = name;
            this.listOfProducts = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Extensions.Validator.CheckForNullOrEmpty(value);
                Extensions.Validator.CheckIsInRangeCategories(value.Length, "name", 2, 15);
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Extensions.Validator.CheckForNullOrEmpty(cosmetics);
            this.listOfProducts.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!this.listOfProducts.Contains(cosmetics))
            {
                throw new InvalidOperationException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));

            }
            this.listOfProducts.Remove(cosmetics);
        }

        public string Print()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("{0} category - {1} {2} in total"
                , this.Name, this.listOfProducts.Count, this.listOfProducts.Count == 1 ? "product" : "products"));

            var sortedProducts = this.listOfProducts.OrderBy(x => x.Brand).ThenByDescending(x => x.Price);

            foreach (var product in sortedProducts)
            {
                result.AppendLine(product.Print());
            }
            return result.ToString().Trim();
        }
    }
}
