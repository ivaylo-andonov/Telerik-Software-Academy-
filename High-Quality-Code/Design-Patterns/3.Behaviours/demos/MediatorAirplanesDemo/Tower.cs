namespace MediatorAirplanesDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MediatorAirplanesDemo.Airplanes;

    public class Tower : IAirTrafficControl
    {
        private IList<Airplane> aircraftUnderGuidance = new List<Airplane>();

        public void ReceiveAircraftLocation(Airplane reportingAircraft)
        {
            foreach (Airplane currentAircraftUnderGuidance in this.aircraftUnderGuidance.Where(x => x != reportingAircraft))
            {
                if (Math.Abs(currentAircraftUnderGuidance.CurrentAltitude - reportingAircraft.CurrentAltitude) < 1000)
                {
                    Console.WriteLine("Air traffic control changed the altitude of {0}", reportingAircraft.CallSign);
                    reportingAircraft.CurrentAltitude += 1000;  
                  
                    // Communicate to the class
                    currentAircraftUnderGuidance.WarnOfAirspaceIntrusionBy(reportingAircraft);
                }
            }
        }

        public void RegisterAircraftUnderGuidance(Airplane aircraft)
        {
            if (!this.aircraftUnderGuidance.Contains(aircraft))
            {
                this.aircraftUnderGuidance.Add(aircraft);
            }
        }
    }
}
