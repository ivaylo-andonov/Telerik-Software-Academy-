namespace YuGiOh.Players
{
    using System.Collections.Generic;
    using YuGiOh.Extensions;
    using YuGiOh.Interfaces;
    using YuGiOh.Cards;
    using System;
    using System.Threading;

    public class FirstHero : IPlayer
    {
        private const int GENERAL_HEALTH_POINTS = 2000;

        private IDeck playerOneDeck;
        private IList<ICard> yuGiOhCardsInHand;
        private int generalHealthPoints;
        private string name;

        public FirstHero(string name)
        {
            this.playerOneDeck = new Deck();
            this.yuGiOhCardsInHand = new List<ICard>();
            this.generalHealthPoints = GENERAL_HEALTH_POINTS;
            this.Name = name;
        }

        public IDeck PlayerDeck
        {
            get { return this.playerOneDeck; }
            set { this.playerOneDeck = value; } 
        }

        public int GeneralHealth
        {
            get { return this.generalHealthPoints; }
            set { this.generalHealthPoints = value;}
        }

        public IList<ICard> YuGiOhCardInHand
        {
            get { return this.yuGiOhCardsInHand; }
             set { this.yuGiOhCardsInHand = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
       
        public void GiveCardToFirstPlayer()
        {
            var card = this.playerOneDeck.DrawNextCard();
            this.yuGiOhCardsInHand.Add(card);
        }

        public void DrawPlayCardsFromYuGiOhDeck(int numberOfPlayableCards)
        {
            if (numberOfPlayableCards > 12)
            {
                throw new ExtendedGameExeption("YuGiOh play cards in hand cannot be more than 12");
            }
            for (int i = 0; i < numberOfPlayableCards; i++)
            {
                this.GiveCardToFirstPlayer();
            }
           
        }
        public void VisionCardInHand()
        {
            
            foreach (var item in this.yuGiOhCardsInHand)
            {
                Console.WriteLine("{0} ", item.ToString());
                Thread.Sleep(1000);
            }
        }

        public void DrawNextCardInHand()
        {
            if (this.playerOneDeck.CardsLeft < 1)
            {
                throw new ExtendedGameExeption("The general YuGiOh deck doesn`t has more cards!");
            }
            this.yuGiOhCardsInHand.Add(this.playerOneDeck.DrawNextCard());
        }

        public void SendCardToField(ICard choosenCard)
        {
            this.yuGiOhCardsInHand.Remove(choosenCard);
        }
    }
}
