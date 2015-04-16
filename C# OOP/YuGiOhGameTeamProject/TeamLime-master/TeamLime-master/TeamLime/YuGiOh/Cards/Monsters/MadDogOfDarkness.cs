namespace YuGiOh.Cards.Monsters
{
    using YuGiOh.Interfaces;
    public class MadDogOfDarkness:Monster, IMonster, ICard
    {
        private const int attack = 1900;
        private const int defence = 1400;
        private const int level = 4;
        private const string pathToImage = "../../CardsPhoto/Monster/MadDogofDarkness.jpg";
        private const string infoText = "He used to be a normal dog who played around in a park, but was corrupted by the powers of darkness.";
        public MadDogOfDarkness()
            : base(MonsterAttribute.Dark, attack, defence, level, infoText, pathToImage)
        {
            
        }
    }
}