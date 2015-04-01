namespace TradeAndTravel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Forest : Location, IGatheringLocation
    {
        public Forest(string name):
            base(name,LocationType.Forest)
        {
            this.GatheredType = ItemType.Wood;
            this.RequiredItem = ItemType.Weapon;
        }

        
        public ItemType GatheredType
        {
            get;
            set;
        }

        public ItemType RequiredItem
        {
            get;
            set;
        }

        public Item ProduceItem(string name)
        {
            return new Wood(name, null);
        }
    }
}
