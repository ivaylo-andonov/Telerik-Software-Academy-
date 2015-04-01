namespace TradeAndTravel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Weapon : Item
    {
        private const int moneyValue = 10;

        public Weapon(string name, Location location = null)
            : base(name, Weapon.moneyValue, ItemType.Weapon, location)
        {

        }
    }
}
