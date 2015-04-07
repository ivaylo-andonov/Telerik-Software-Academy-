namespace Cosmetics.Products
{

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Shampoo: Product, IShampoo
    {
        private uint milliliters;
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            :base(name,brand,price * milliliters,gender)           
        {
            this.Milliliters = milliliters;
            this.Usage = usage;          
        }
        public uint Milliliters
        {
            get { return this.milliliters; }
            private set 
            {
                Extensions.Validator.CheckNegativeValues(value);
                this.milliliters = value;
            }
        }      
        
        public Common.UsageType Usage
        {
            get { return this.usage; }
            private set 
            {               
                this.usage = value;
            }
        }

        public override string Print()
        {
            return base.Print() + string.Format("\n  * Quantity: {0} ml\n  * Usage: {1}",this.Milliliters,this.Usage.ToString());
        }
    }
}
