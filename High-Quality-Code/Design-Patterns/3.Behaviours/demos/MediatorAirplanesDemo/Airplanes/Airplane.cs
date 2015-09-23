namespace MediatorAirplanesDemo.Airplanes
{
    using System;

    public abstract class Airplane
    {
        private readonly IAirTrafficControl airTrafficControl;
        private int currentAltitude;

        protected Airplane(string callSign, IAirTrafficControl airTrafficControl)
        {
            this.CallSign = callSign;
            this.airTrafficControl = airTrafficControl;      
            airTrafficControl.RegisterAircraftUnderGuidance(this);
        }
 
        public string CallSign { get; private set; }
 
        public int CurrentAltitude
        {
            get 
            { 
                return this.currentAltitude; 
            }

            set
            {
                this.currentAltitude = value;
                Console.WriteLine("Airplane {0} changed his altitude to {1}", this.CallSign, this.CurrentAltitude);
                this.airTrafficControl.ReceiveAircraftLocation(this);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            var incoming = (Airplane)obj;
            return this.CallSign.Equals(incoming.CallSign);
        }

        public override int GetHashCode()
        {
            return this.CallSign.GetHashCode();
        }

        public void WarnOfAirspaceIntrusionBy(Airplane reportingAircraft)
        {
            Console.WriteLine("Airplane {0} has changed his Altitude to avoid Collision", reportingAircraft.CallSign);
        }
    }
}
