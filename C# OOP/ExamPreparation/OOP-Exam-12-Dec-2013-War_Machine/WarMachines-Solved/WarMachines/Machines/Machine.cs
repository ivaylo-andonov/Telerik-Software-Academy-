namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using WarMachines.Interfaces;

    public abstract class Machine: IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private List<string> attackTargets;

        public Machine(string initialName, double healthPoints, double attackPoints, double defensePoints)
        {
            this.Name = initialName;
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.attackTargets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The pilot cannot be null");
                }
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Points cannot be negative");
                }
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get { return this.attackPoints; }
            protected set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Points cannot be negative");
                }
                this.attackPoints = value;
            }
        }
       

        public double DefensePoints
        {
            get { return this.defensePoints; }
            protected set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Points cannot be negative");
                }
                this.defensePoints = value;
            }
        }

        public IList<string> Targets
        {
            get { return this.attackTargets; }           
        }

        public void Attack(string target)
        {
            this.Targets.Add(target);
        }

        public override string ToString()
        {
            string result = (string.Format("- {0}\n *Type: {1}\n *Health: {2}\n *Attack: {3}\n *Defense: {4}\n *Targets: {5}",
                this.name, this.GetType().Name,this.healthPoints,this.attackPoints,this.defensePoints,
                this.Targets.Count == 0? "None": string.Join(", ",this.Targets)));

            return result;
        }
    }
}
