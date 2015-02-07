using System;

class Program
{
    static void Main()
    {
        int tomatoSeeds = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberSeeds = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int potatoSeeds = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrotSeeds = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbageSeeds = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beansSeeds = int.Parse(Console.ReadLine());

        int peshoArea = 250;
        int areaWhitoutBeans = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
        int beansArea = peshoArea - areaWhitoutBeans;
        double totalCosts = 0.5 * tomatoSeeds + 0.4 * cucumberSeeds + 0.25 * potatoSeeds + 0.6 * carrotSeeds
                            + 0.3 * cabbageSeeds + 0.4 * beansSeeds;

        Console.WriteLine("Total costs: {0:0.00}",totalCosts);

        if (beansArea > 0)
        {
            Console.WriteLine("Beans area: {0}", beansArea );
        }
        else if (beansArea == 0 )
        {
            Console.WriteLine("No area for beans");
        }
        else if (beansArea < 0)
        {
            Console.WriteLine("Insufficient area");
        }
    }
}

