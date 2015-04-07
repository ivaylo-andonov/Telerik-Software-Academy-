namespace Cosmetics.Products
{
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public abstract class Product : IProduct
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;

        public Product(string name, string brand, decimal price, GenderType genderType)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = genderType;
        }

        public string Name
        {
            get { return this.name; }
            private set 
            {
                Extensions.Validator.CheckForNullOrEmpty(value);
                Extensions.Validator.CheckIsInRangeProducts(value.Length, "name", 3, 10);
                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.name; }

            private set
            {
                Extensions.Validator.CheckForNullOrEmpty(value);
                Extensions.Validator.CheckIsInRangeProducts(value.Length, "brand", 2, 10);
                this.brand = value;
            }
        }

        public decimal Price
        {
            get { return this.price ; }
            private set
            {
                Extensions.Validator.CheckNegativeValues(value);               
                this.price = value;
            }
        }

        public Common.GenderType Gender
        {
            get { return this.gender ; }
            private set { this.gender = value; }
        }

        public virtual string Print()
        {            
            var result = new StringBuilder();
            result.AppendLine(string.Format("- {0} - {1}:",this.brand,this.name));
            result.Append(string.Format("  * Price: ${0}\n  * For gender: {1}",this.Price,this.Gender.ToString()));

            return result.ToString().TrimEnd();
        }
    }
}
