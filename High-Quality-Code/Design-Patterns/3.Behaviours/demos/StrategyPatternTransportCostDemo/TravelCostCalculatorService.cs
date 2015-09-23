namespace StrategyPatternTransportCostDemo
{
    using System;

    public class TravelCostCalculatorService
    {
        private readonly ICalculateCost travelStrategy;

        public TravelCostCalculatorService(ICalculateCost travelStrategy)
        {
            this.travelStrategy = travelStrategy;
        }

        public void DisplayCost(double distance)
        {
            var costs = this.travelStrategy.CalculateCost(distance);
            Console.WriteLine("Travelling {0}km with {1} would cost you {2:C2}", distance, this.travelStrategy.GetType().Name, costs);
        }
    }
}
