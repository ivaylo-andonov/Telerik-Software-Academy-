namespace AcademyEcosystem
{
    public class Zombie:Animal
    {
        private const int Meat_Portion = 10;

        public Zombie(string name, Point position)
            : base(name, position, 0)
        {
        }

        public override int GetMeatFromKillQuantity()
        {
            return Meat_Portion;
        }
    }
}
