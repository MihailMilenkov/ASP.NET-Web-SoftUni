namespace CSharpProgrammingBasics._03SimpleOperationsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _09AlcoholMarket
    {
        internal static void Start()
        {
            double whiskeyPriceInLeva = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiaLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());

            double totalwhiskeyPrice = whiskeyLiters * whiskeyPriceInLeva;
            double rakiaPrice = whiskeyPriceInLeva / 2;
            //double winePrice = rakiaPrice - 40 / 100 * rakiaPrice;
            double winePrice = rakiaPrice * 0.6;
            double beerPrice = rakiaPrice * 0.2;

            double totalRakiaPrice = rakiaLiters * rakiaPrice;
            double totalWinePrice = wineLiters * winePrice;
            double totalBeerPrice = beerLiters * beerPrice;

            double total = totalBeerPrice + totalRakiaPrice + totalWinePrice + totalwhiskeyPrice;
            Console.WriteLine($"{total:f2}");
        }
    }
}
