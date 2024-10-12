namespace CSharpProgrammingBasics._03SimpleOperationsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _08CharityCampaign
    {
        internal static void Start()
        {
            double days = double.Parse(Console.ReadLine());
            double bakers = double.Parse(Console.ReadLine());
            double numCakes = double.Parse(Console.ReadLine());
            double numCorrugations = double.Parse(Console.ReadLine());
            double numPancakes = double.Parse(Console.ReadLine());

            double cakePrice = 45;
            double corrugationPrice = 5.8;
            double pancakePrice = 3.2;

            double totalCake = cakePrice * numCakes;
            double totalCorrugation = corrugationPrice * numCorrugations;
            double totalPancake = pancakePrice * numPancakes;

            totalCake = (totalCake + totalCorrugation + totalPancake) * days * bakers;
            totalCake = totalCake * 7 / 8;

            Console.WriteLine($"{totalCake:f2}");
        }
    }
}
