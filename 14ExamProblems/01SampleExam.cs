namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _01SampleExam
    {
        internal static void Start()
        {
            double priceForFoodPerDay = double.Parse(Console.ReadLine());
            double priceForSouvenirsPerDay = double.Parse(Console.ReadLine());
            double priceForHotelPerDay = double.Parse(Console.ReadLine());

            double priceForFuel = (7 * 4.2) * 1.85;
            double totalPriceForHotel = priceForHotelPerDay * .9 + priceForHotelPerDay * .85 + priceForHotelPerDay * .8;
            double totalPriceForSouvenirs = priceForSouvenirsPerDay * 3;
            double totalPriceForFood = priceForFoodPerDay * 3;

            Console.WriteLine($"Money needed: {priceForFuel + totalPriceForFood + totalPriceForHotel + totalPriceForSouvenirs:f2}");
        }
    }
}
