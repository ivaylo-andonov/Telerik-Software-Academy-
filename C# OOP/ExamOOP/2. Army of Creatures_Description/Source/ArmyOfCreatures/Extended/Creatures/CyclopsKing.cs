namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Extended.Specialties;

    public class CyclopsKing: Creature
    {
        public CyclopsKing() 
            : base(17,13, 70, 18)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}
