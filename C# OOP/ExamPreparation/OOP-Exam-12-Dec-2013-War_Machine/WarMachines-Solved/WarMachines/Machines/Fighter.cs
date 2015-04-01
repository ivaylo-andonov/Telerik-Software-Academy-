namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    public class Fighter:Machine,IFighter
    {
        private bool isStealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            :base(name,200, attackPoints,defensePoints)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode
        {
            get { return this.isStealthMode; }
            private set { this.isStealthMode = value; }
        }

        public void ToggleStealthMode()
        {
            if (isStealthMode)
            {
                isStealthMode = false;
            }
            else
            {
                isStealthMode = true;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n *Stealth: {0}", this.StealthMode ? "ON" : "OFF");
        }       
    }
}
