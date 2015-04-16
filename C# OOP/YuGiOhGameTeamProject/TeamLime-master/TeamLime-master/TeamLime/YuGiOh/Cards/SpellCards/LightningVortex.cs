namespace YuGiOh.Cards.SpellCards
{
    using YuGiOh.Interfaces;
    public class LightningVortex:Spell, ISpell, ICard
    {
        private const string infoText = "Discard 1 card; destroy all face-up monsters your opponent controls.";
        private const string pathToImage = "../../CardsPhoto/Spell/LightningVortex.jpg";
        public LightningVortex()
            :base(SpellTypes.Normal, infoText, pathToImage)
        {

        }
    }
}