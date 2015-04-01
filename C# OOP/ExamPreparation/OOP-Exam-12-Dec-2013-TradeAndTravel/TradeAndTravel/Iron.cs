namespace TradeAndTravel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Iron : Item
    {
        private const int moneyValue = 3;

        public Iron(string name, Location location = null)
            : base(name, Iron.moneyValue, ItemType.Iron, location)
        {

        }
    }
}
