namespace YuGiOh.Cards.TrapCards
{
    using YuGiOh.Interfaces;
    public class NegateAttack : Trap, ITrap, ICard
    {
        private const string infoText = "Activate only when a target opponent's monster declares an attack. Negate the attack and end the Battle Phase.";
        private const string pathToImage = "../../CardsPhoto/Trap/NegateAttack.jpg";
        public NegateAttack()
            : base(TrapTypes.Counter, infoText, pathToImage)
        {

        }
    }
}