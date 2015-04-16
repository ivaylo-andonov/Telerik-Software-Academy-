namespace YuGiOh.Cards.Monsters
{
    using YuGiOh.Interfaces;
    public class ArchfiendSoldier:Monster, IMonster, ICard
    {
        private const int attack = 1900;
        private const int defence = 1500;
        private const int level = 4;
        private const string pathToImage = "../../CardsPhoto/Monster/ArchfiendSoldier.jpg";
        private const string infoText = "An expert at battle who belongs to a crack diabolical unit. He's famous because he always gets the job done.";
        public ArchfiendSoldier()
            : base(MonsterAttribute.Dark, attack, defence, level, infoText, pathToImage)
        {
            
        }
    }
}