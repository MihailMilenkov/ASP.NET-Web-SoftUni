namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _04BachelorParty
    {
        internal static void Start()
        {
            double priceForSinger = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double moneyFromGuests = 0;
            double totalGuests = 0;

            while (input != "The restaurant is full")
            {
                double inputAsNum = int.Parse(input);
                totalGuests += inputAsNum;

                if (inputAsNum < 5)
                {
                    moneyFromGuests += inputAsNum * 100;
                }
                else
                {
                    moneyFromGuests += inputAsNum * 70;
                }
                input = Console.ReadLine();
            }

            if (moneyFromGuests >= priceForSinger)
            {
                Console.WriteLine($"You have {totalGuests} guests and {moneyFromGuests - priceForSinger} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {totalGuests} guests and {moneyFromGuests} leva income, but no singer.");
            }
        }
    }
}
