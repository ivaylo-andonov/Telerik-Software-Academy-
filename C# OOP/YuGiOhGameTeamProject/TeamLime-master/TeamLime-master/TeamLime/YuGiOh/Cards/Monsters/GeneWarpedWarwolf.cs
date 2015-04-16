namespace YuGiOh.Cards.Monsters
{
    using YuGiOh.Interfaces;
    public class GeneWarpedWarwolf:Monster, IMonster, ICard
    {
        private const int attack = 2000;
        private const int defence = 100;
        private const int level = 4;
        private const string pathToImage = "../../CardsPhoto/Monster/GeneWarpedWarwolf.jpg";
        private const string infoText = "This warwolf was given incalculable strength through horrific genetic manipulation. Its gentle nature was completely wiped out, and it now lives only to unleash destruction.";

        public GeneWarpedWarwolf()
            : base(MonsterAttribute.Dark, attack, defence, level, infoText, pathToImage)
        {
            
        }
    }
}