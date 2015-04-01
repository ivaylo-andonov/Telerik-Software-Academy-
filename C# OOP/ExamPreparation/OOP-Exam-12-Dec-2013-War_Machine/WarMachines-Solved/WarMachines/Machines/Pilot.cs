namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    public class Pilot: IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.Machines = new List<IMachine>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Cannot be null.");
                }
                this.name = value;
            }
        }

        public IList<IMachine> Machines
        {
            get { return this.machines; }
            private set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The list cannot be null");
                }
                this.machines = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.Machines.Add(machine);
        }

        public string Report()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("{0} - {1} {2}",
                this.Name,
                this.Machines.Count == 0? "no": this.Machines.Count.ToString(),
                this.Machines.Count == 1? "machine" : "machines"));

            var sortedMachines = this.Machines.OrderBy(x => x.HealthPoints).ThenBy(x => x.Name);

            foreach (var machine in sortedMachines)
            {
                result.AppendLine(machine.ToString());
            }
            return result.ToString().Trim();
        }      
    }
}
