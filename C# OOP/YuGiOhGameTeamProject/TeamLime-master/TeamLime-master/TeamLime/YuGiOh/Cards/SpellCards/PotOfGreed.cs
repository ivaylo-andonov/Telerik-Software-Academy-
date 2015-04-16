namespace YuGiOh.Cards.SpellCards
{
    using YuGiOh.Interfaces;
    public class PotOfGreed:Spell, ISpell, ICard
    {
        private const string infoText = "Draw 2 cards.";
        private const string pathToImage = "../../CardsPhoto/Spell/PotofGreed.jpg";
        public PotOfGreed()
            :base(SpellTypes.Normal, infoText, pathToImage)
        {

        }
    }
}