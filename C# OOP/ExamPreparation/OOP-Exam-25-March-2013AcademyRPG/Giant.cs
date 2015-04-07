namespace AcademyRPG
{
    public class Giant: Character,IFighter,IGatherer
    {
        private int attackPoints;
        private bool isGathered;

        public Giant(string name, Point position)
            : base(name, position, 0)
        {
            this.HitPoints = 200;
            this.attackPoints = 150;
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
        }

        public int DefensePoints
        {
            get { return 80; }
        }

        public int GetTargetIndex(System.Collections.Generic.List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if ( availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (!isGathered)
                {
                    this.attackPoints += 100;
                    isGathered = true;
                }
                return true;
            }
            return false;
        }
    }
}
