namespace YuGiOh.Cards.TrapCards
{
    using YuGiOh.Interfaces;
    public class MirrorForce:Trap, ITrap, ICard
    {
        private const string infoText = "When an opponent's monster declares an attack: Destroy all Attack Position monsters your opponent controls.";
        private const string pathToImage = "../../CardsPhoto/Trap/MirrorForce.jpg";
        public MirrorForce()
            :base(TrapTypes.Normal, infoText, pathToImage)
        {

        }
    }
}