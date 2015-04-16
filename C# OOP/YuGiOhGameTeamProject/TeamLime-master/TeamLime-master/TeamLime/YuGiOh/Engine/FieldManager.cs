using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOh.Engine
{
    using Extensions;
    using YuGiOh.Cards;
    using YuGiOh.Players;

    public class FieldManager: IFieldManager
    {
        private FirstHero playerOne;
        private SecondHero playerTwo;
        private BattleField battlefield;

        public FieldManager(FirstHero playerOne, SecondHero playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            this.battlefield = new BattleField();
        }

        public void Attack(CardId atackingCard, Extensions.CardId defendingCard)
        {
            throw new NotImplementedException("Sorry, It`s DEMO version.Next couple weeks it`s gonna be finished.");
        }

        public void Play(CardId atackingCard)
        {
            string cardName = atackingCard.CardName;
            PlayerIndentifier choosenPlayer = atackingCard.PlayerIdentifier;

            var hand = choosenPlayer == (PlayerIndentifier)1 ? playerOne.YuGiOhCardInHand : playerTwo.YuGiOhCardInHand;
            var card = hand.FirstOrDefault(c => c.GetType().Name == cardName);

            if (card == null)
            {
                throw new ArgumentNullException("card to play needed");
            }

            this.battlefield.cardsOnField.Add(card);
            this.playerOne.SendCardToField(card);
            
        }

        public void Switch(CardId atackingCard)
        {

            string cardName = atackingCard.CardName;
            PlayerIndentifier choosenPlayer = atackingCard.PlayerIdentifier;

            foreach (var card in this.battlefield.cardsOnField)
            {
                if (card.GetType().Name == cardName)
                {
                    card.SwitchPosition();
                    break;
                }
            }
        }
    }
}
