namespace MediatorAirplanesDemo.Airplanes
{
    public class Boeing : Airplane
    {
        public Boeing(string callSign, IAirTrafficControl airTrafficControl)
            : base(callSign, airTrafficControl)
        {
        }
    }
}
