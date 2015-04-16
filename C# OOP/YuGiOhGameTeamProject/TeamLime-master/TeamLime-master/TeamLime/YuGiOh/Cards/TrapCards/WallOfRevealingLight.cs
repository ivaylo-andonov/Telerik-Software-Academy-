namespace YuGiOh.Cards.TrapCards
{
    using YuGiOh.Interfaces;
    public class WallOfRevealingLight: Trap, ITrap, ICard
    {
        private const string infoText = "Activate by paying any multiple of 1000 Life Points. Monsters your opponent controls cannot attack if their ATK is less than or equal to the amount you paid.";
        private const string pathToImage = "../../CardsPhoto/Trap/WallofRevealingLight.jpg";
        public WallOfRevealingLight()
            : base(TrapTypes.Continuous, infoText, pathToImage)
        {

        }
    }
}