namespace YuGiOh.Cards.Monsters
{
    using YuGiOh.Interfaces;
    public class VorseRaider:Monster, IMonster, ICard
    {
        private const int attack = 1900;
        private const int defence = 1200;
        private const int level = 4;
        private const string pathToImage = "../../CardsPhoto/Monster/VorseRaider.jpg";
        private const string infoText = "This wicked Beast-Warrior does every horrid thing imaginable, and loves it! His axe bears the marks of his countless victims.";
        public VorseRaider()
            : base(MonsterAttribute.Dark, attack, defence, level, infoText, pathToImage)
        {
            
        }
    }
}