namespace CSharpProgrammingBasics._07NestedConditionalStatementsEcercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _05FishingBoat
    {
        internal static void Start()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numMen = int.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Spring")
            {
                if (numMen <= 6)
                {
                    price = 3000 * 0.9;
                }
                else if (numMen >= 7 & numMen <= 11)
                {
                    price = 3000 * 0.85;
                }
                else if (numMen >= 12)
                {
                    price = 3000 * 0.75;
                }
            }

            else if (season == "Summer" || season == "Autumn")
            {
                if (numMen <= 6)
                {
                    price = 4200 * 0.9;
                }
                else if (numMen >= 7 & numMen <= 11)
                {
                    price = 4200 * 0.85;
                }
                else if (numMen >= 12)
                {
                    price = 4200 * 0.75;
                }
            }

            else if (season == "Winter")
            {
                if (numMen <= 6)
                {
                    price = 2600 * 0.9;
                }
                else if (numMen >= 7 & numMen <= 11)
                {
                    price = 2600 * 0.85;
                }
                else if (numMen >= 12)
                {
                    price = 2600 * 0.75;
                }
            }

            if (numMen % 2 == 0 && season != "Autumn")
            {
                price *= .95;
            }

            double diff = Math.Abs(budget - price);

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {diff:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
            }
        }
    }
}
