namespace YuGiOh.Cards.SpellCards
{
    using YuGiOh.Interfaces;
    public class MysticalSpaceTyphoon:Spell, ISpell, ICard
    {
        private const string infoText = "Target 1 Spell/Trap Card on the field; destroy that target.";
        private const string pathToImage = "../../CardsPhoto/Spell/MysticalSpaceTyphoon.jpg";
        public MysticalSpaceTyphoon()
            :base(SpellTypes.QuickPlay, infoText, pathToImage)
        {

        }
    }
}