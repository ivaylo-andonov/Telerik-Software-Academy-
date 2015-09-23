namespace MediatorAirplanesDemo
{
    using MediatorAirplanesDemo.Airplanes;

    public interface IAirTrafficControl
    {
        void ReceiveAircraftLocation(Airplane reportingAircraft);

        void RegisterAircraftUnderGuidance(Airplane aircraft);
    }
}
