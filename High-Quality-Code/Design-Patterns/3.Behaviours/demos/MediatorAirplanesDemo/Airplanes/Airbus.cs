namespace MediatorAirplanesDemo.Airplanes
{
    public class Airbus : Airplane
    {
        public Airbus(string callSign, IAirTrafficControl airTrafficControl)
            : base(callSign, airTrafficControl)
        {
        }
    }
}
