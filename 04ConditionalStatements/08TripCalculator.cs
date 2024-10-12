namespace CSharpProgrammingBasics._04ConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _08TripCalculator
    {
        internal static void Start()
        {
            double priceForTrip = double.Parse(Console.ReadLine());
            double money = 5;

            if (money >= priceForTrip)
            {
                double moneyLeft = money - priceForTrip;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeeded = priceForTrip - money;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");

            }
        }
    }
}
