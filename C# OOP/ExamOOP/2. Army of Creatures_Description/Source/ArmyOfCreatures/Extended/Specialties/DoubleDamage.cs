namespace ArmyOfCreatures.Extended.Specialties
{
    using ArmyOfCreatures.Logic.Specialties;
    using System;
    using System.Globalization;

    public class DoubleDamage: Specialty
    {
        private int playedROunds;

        public DoubleDamage(int rounds)
        {
            if (rounds <= 0)
            {
                throw new ArgumentOutOfRangeException("Should be freater than 0");
            }
            if (rounds > 10)
            {
                throw new ArgumentOutOfRangeException("SHould be smaller than 10");
            }

            this.playedROunds = rounds;
        }
        public override decimal ChangeDamageWhenAttacking(Logic.Battles.ICreaturesInBattle attackerWithSpecialty,
            Logic.Battles.ICreaturesInBattle defender, decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (playedROunds == 0)
            {
                return currentDamage;
            }
            this.playedROunds--;
            return currentDamage * 2;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}{1}", base.ToString(), this.playedROunds);
        }
    }
}
