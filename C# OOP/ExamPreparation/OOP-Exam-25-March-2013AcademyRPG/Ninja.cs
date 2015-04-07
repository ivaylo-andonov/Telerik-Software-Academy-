namespace AcademyRPG
{
    using System.Linq;

    public class Ninja : Character, IFighter, IGatherer
    {
        private int attackPoints;

        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;
            this.attackPoints = 0;
        }

        public new bool IsDestroyed
        {
            get
            {
                return false;
            }
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
        }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(System.Collections.Generic.List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0
                    && availableTargets[i].HitPoints == availableTargets.Max(x => x.HitPoints))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone || resource.Type == ResourceType.Lumber)
            {
                if (resource.Type == ResourceType.Stone)
                {
                    this.attackPoints += resource.Quantity * 2;
                }
                else if (resource.Type == ResourceType.Lumber)
                {
                    this.attackPoints += resource.Quantity;
                }

                return true;
            }
            return false;
        }
    }
}
