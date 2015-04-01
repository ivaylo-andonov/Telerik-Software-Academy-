namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    class Tank: Machine,ITank
    {
        private bool isDefenseMode;

        public Tank(string name, double attackPoints, double defensePoints):
            base(name,100,attackPoints,defensePoints)
        {
            this.DefenseMode = true;
            this.AttackPoints -= 40;
            this.DefensePoints += 30;
        }

        public bool DefenseMode
        {
            get { return this.isDefenseMode; }
            private set { this.isDefenseMode = value; }
        }

        public void ToggleDefenseMode()
        {
            if (isDefenseMode)
            {
                isDefenseMode = false;
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
            else
            {
                isDefenseMode = true;
                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n *Defense: {0}", this.DefenseMode ? "ON" : "OFF");
        }       
    }
}
