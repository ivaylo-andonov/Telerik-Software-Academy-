namespace YuGiOh.Cards.SpellCards
{
    using YuGiOh.Interfaces;
    public class Raigeki:Spell, ISpell, ICard
    {
        private const string infoText = "Destroy all monsters your opponent controls.";
        private const string pathToImage = "../../CardsPhoto/Spell/Raigeki.jpg";
        public Raigeki()
            :base(SpellTypes.Normal, infoText, pathToImage)
        {

        }
    }
}