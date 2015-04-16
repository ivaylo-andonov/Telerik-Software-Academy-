namespace YuGiOh.Cards.SpellCards
{
    using YuGiOh.Interfaces;
    public class DoubleSummon:Spell, ISpell, ICard
    {
        private const string infoText = "You can conduct 2 Normal Summons/Sets this turn, not just 1.";
        private const string pathToImage = "../../CardsPhoto/Spell/DoubleSummon.jpg";
        public DoubleSummon()
            :base(SpellTypes.Normal, infoText, pathToImage)
        {

        }
    }
}