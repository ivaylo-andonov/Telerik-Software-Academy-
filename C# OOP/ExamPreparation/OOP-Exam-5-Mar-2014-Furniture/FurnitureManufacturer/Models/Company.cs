namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private readonly ICollection<IFurniture> furnitures;

        public Company(string name, string regNumber)
        {
            this.Name = name;
            this.RegistrationNumber = regNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (!string.IsNullOrEmpty(value) || value.Length >= 5)
                {
                    this.name = value;
                }
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            private set
            {
                if (value.Length == 10 || IsDigitsOnly(value))
                {
                    this.registrationNumber = value;
                }
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return new List<IFurniture>(this.furnitures);
            }
        }

        public void Add(IFurniture furniture)
        {
            this.Furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.Furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.Furnitures.FirstOrDefault(x => x.Model.ToUpper() == model.ToUpper());
        }

        public string Catalog()
        {
            StringBuilder result = new StringBuilder();
            if (this.Furnitures.Count != 0)
            {
                result.AppendLine(string.Format("{0} - {1} - {2} {3}",
            this.Name,
            this.RegistrationNumber,
            this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
            this.Furnitures.Count != 1 ? "furnitures" : "furniture"));
            }
            else
            {
                result.Append(string.Format("{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture"));
            }

            var col = this.Furnitures.OrderBy(x => x.Price).ThenBy(y => y.Model).ToList();

            for (int i = 0; i < col.Count; i++)
            {
                if (i == col.Count - 1)
                {
                    result.Append(col.ToList()[i].ToString());
                }
                else
                {
                    result.AppendLine(col.ToList()[i].ToString());
                }
            }

            return result.ToString();
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
