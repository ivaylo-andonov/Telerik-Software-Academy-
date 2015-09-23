namespace StrategyPatternTransportCostDemo
{
    public class PersonalCar : ICalculateCost
    {
        private const decimal CostsPerKm = 0.55M;

        public decimal CalculateCost(double distace)
        {
            return (decimal)distace * CostsPerKm;
        }
    }
}
