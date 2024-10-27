namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _08AddBags
    {
        internal static void Start()
        {
            double priceForLuggageOver20Kilos = double.Parse(Console.ReadLine());
            double kilosOfLuggage = double.Parse(Console.ReadLine());
            double daysUntilTravel = double.Parse(Console.ReadLine());
            double piecesOfLuggage = double.Parse(Console.ReadLine());

            double price = 0;

            if (kilosOfLuggage < 10)
            {
                price = priceForLuggageOver20Kilos * .2;
            }
            else if (kilosOfLuggage <= 20)
            {
                price = priceForLuggageOver20Kilos * .5;
            }
            else
            {
                price = priceForLuggageOver20Kilos;
            }

            if (daysUntilTravel < 7)
            {
                price *= 1.4;
            }
            else if (daysUntilTravel <= 30)
            {
                price *= 1.15;
            }
            else
            {
                price *= 1.1;
            }

            Console.WriteLine($"The total price of bags is: {price * piecesOfLuggage:f2} lv.");
        }
    }
}
