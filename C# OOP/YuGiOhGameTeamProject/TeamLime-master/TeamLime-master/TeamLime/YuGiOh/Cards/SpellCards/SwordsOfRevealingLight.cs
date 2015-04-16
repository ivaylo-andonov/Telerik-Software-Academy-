namespace YuGiOh.Cards.SpellCards
{
    using YuGiOh.Interfaces;
    public class SwordsOfRevealingLight:Spell, ISpell, ICard
    {
        private const string infoText = "This card remains on the field for 3 of your opponent's turns. While this card is face-up on the field, monsters your opponent controls cannot declare an attack.";
        private const string pathToImage = "../../CardsPhoto/Spell/SwordsofRevealingLight.jpg";
        public SwordsOfRevealingLight()
            :base(SpellTypes.Normal, infoText, pathToImage)
        {

        }
    }
}