namespace YuGiOh.Cards.Monsters
{
    using YuGiOh.Interfaces;
    public class GeminiElf:Monster, IMonster, ICard
    {
        private const int attack = 1900;
        private const int defence = 900;
        private const int level = 4;
        private const string pathToImage = "../../CardsPhoto/Monster/GemininElf.jpg";
        private const string infoText = "Elf twins that alternate their attacks.";

        public GeminiElf()
            : base(MonsterAttribute.Earth, attack, defence, level, infoText, pathToImage)
        {
            
        }
    }
}
