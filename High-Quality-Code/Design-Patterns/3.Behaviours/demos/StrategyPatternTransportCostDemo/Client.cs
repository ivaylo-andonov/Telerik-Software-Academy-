namespace StrategyPatternTransportCostDemo
{
    using System;

    public class Client
    {
        public static void Main()
        {
            double distanceToGradina = 410;
            var travelTypeOne = new PersonalCar();
            var getCosts = new TravelCostCalculatorService(travelTypeOne);
            getCosts.DisplayCost(distanceToGradina);

            Console.WriteLine(new string('-', 50));

            var travelTypeTwo = new PublicTransport();
            getCosts = new TravelCostCalculatorService(travelTypeTwo);
            getCosts.DisplayCost(distanceToGradina);
        }
    }
}
