namespace Cosmetics.Products
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Toothpaste : Product, IToothpaste
    {
        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            if (ingredients.Any(i => i.Length < 4 || i.Length > 12))
            {
                throw new IndexOutOfRangeException(string.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", 4, 12));
            }

            this.ingredients = ingredients;
        }

        public string Ingredients
        {
            get { return string.Join(", ", this.ingredients); }
        }

        public override string Print()
        {
            return base.Print() + string.Format("\n  * Ingredients: {0}",this.Ingredients );
        }        
    }
}
