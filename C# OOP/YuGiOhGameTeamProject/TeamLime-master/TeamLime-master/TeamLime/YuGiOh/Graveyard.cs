namespace YuGiOh
{
    using System;
    using YuGiOh.Cards;
    using YuGiOh.Interfaces;
    using System.Collections.Generic;
    public class Graveyard:IGraveyard
    {
        private List<Card> cardsInGraveyard;

        public Graveyard()
        {
            this.cardsInGraveyard = new List<Card>();
        }

        public List<Card> CardsInGraveyard
        {
            get
            {
                return this.cardsInGraveyard;
            }
            set
            {
                this.CardsInGraveyard = value;
            }
        }
        public int NumberOfCardsInGraveyard
        {
            get
            {
                return CardsInGraveyard.Count;
            }
        }

        public void SendCardToGraveyard(Card card)
        {
            CardsInGraveyard.Add(card);
        }

        public void RemoveCardFromGraveyard(Card card)
        {
            CardsInGraveyard.Remove(card);
        }
    }
}