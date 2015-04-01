namespace TradeAndTravel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Mine : Location, IGatheringLocation
    {
        public Mine(string name):
            base(name,LocationType.Mine)
        {
            this.GatheredType = ItemType.Iron;
            this.RequiredItem = ItemType.Armor;
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
            return new Iron(name, null);
        }
    }
}
