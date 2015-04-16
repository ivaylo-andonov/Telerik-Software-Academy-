namespace YuGiOh.Cards.TrapCards
{
    using YuGiOh.Interfaces;
    public class DivineWrath: Trap, ITrap, ICard
    {
        private const string infoText = "When a monster effect is activated: Discard 1 card; negate the activation, and if you do, destroy that monster.";
        private const string pathToImage = "../../CardsPhoto/Trap/DivineWrath.jpg";
        public DivineWrath()
            :base(TrapTypes.Counter, infoText, pathToImage)
        {

        }
    }
}