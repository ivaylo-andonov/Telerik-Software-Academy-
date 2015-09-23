namespace MediatorAirplanesDemo
{
    using System;

    using MediatorAirplanesDemo.Airplanes;

    public class Client
    {
        public static void Main()
        {
            IAirTrafficControl tower = new Tower();

            Airplane flightOne = new Airbus("AC159", tower);
            Airplane flightTwo = new Boeing("WS203", tower);

            flightOne.CurrentAltitude = 9000;
            flightTwo.CurrentAltitude = 7500;

            flightOne.CurrentAltitude -= 1000; 
        }
    }
}
