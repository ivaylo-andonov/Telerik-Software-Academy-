namespace YuGiOh.Cards.Monsters
{
    using YuGiOh.Interfaces;

    public sealed class EkzodiA : Monster, IMonster, ICard
    {

        // Here is the implementation of Singleton Design Pattern. It works to create only one instance of some class.The pattern that 
        // allow only one instance and no more.In this case monster-card Ekzodia can invoke only once in the game.

        private static EkzodiA instance;

        private  const int attack = 15000;
        private  const int defence = 1500;
        private  const int level = 9;
        private  const string pathToImage = "../../CardsPhoto/Monster/Ekzodia.jpg";
        private  const string infoText = "The GOD, most powerful card in the world!";

        private EkzodiA()
            : base(MonsterAttribute.Dark, attack, defence, level, infoText, pathToImage)
        {

        }
         
        public static EkzodiA Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EkzodiA();
                }

                return instance;
            }
        }
    }
}
