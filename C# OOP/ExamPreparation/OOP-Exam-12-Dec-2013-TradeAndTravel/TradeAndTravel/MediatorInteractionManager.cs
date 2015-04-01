using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class MediatorInteractionManager : InteractionManager
    {
        public MediatorInteractionManager()
            : base()
        { }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default: return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
            return person;
        }

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    base.CreateItem(itemTypeString, itemNameString, itemLocation, item);

                    break;
            }
            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            switch (locationTypeString)
            {
                case "forest":
                    return new Forest(locationName);
                case "mine":
                    return new Mine(locationName);
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    this.HandleGatherInteraction(actor, commandWords[2]);
                    break;
                case "craft":
                    this.HandleCraftInteraction(actor, commandWords[2], commandWords[3]);
                    break;
                default: base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleCraftInteraction(Person actor, string crafteedItemType, string craftedItemName)
        {

            switch (crafteedItemType)
            {
                default:
                    break;
            }

        }

        private void HandleGatherInteraction(Person actor, string gatheringItemName)
        {
            var gatheringLocation = actor.Location as IGatheringLocation;
            if (gatheringLocation != null)
            {
                var actorInvetory = actor.ListInventory();
                bool hasRequiredItem = actorInvetory.Any(x => x.ItemType == gatheringLocation.RequiredItem);

                if (hasRequiredItem)
                {
                    var producedItem = gatheringLocation.ProduceItem(gatheringItemName);
                    this.AddToPerson(actor, producedItem);
                }
            }
        }
    }
}
