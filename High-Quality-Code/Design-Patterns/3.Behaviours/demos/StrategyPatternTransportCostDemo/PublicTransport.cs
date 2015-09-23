namespace StrategyPatternTransportCostDemo
{
    public class PublicTransport : ICalculateCost
    {
        private const decimal CostsPerKm = 0.17M;

        public decimal CalculateCost(double distace)
        {
            return (decimal)distace * CostsPerKm;
        }
    }
}
