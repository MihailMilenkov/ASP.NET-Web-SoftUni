namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _19BakingCompetition
    {
        internal static void Start()
        {
            double numOfContesters = double.Parse(Console.ReadLine());
            double allBakery = 0;
            double totalSum = 0;

            for (int i = 1; i <= numOfContesters; i++)
            {
                double cookies = 0;
                double cakes = 0;
                double waffles = 0;

                string currentContester = Console.ReadLine();

                string currentType = Console.ReadLine();

                while (currentType != "Stop baking!")
                {
                    double numOfSweets = double.Parse(Console.ReadLine());
                    allBakery += numOfSweets;

                    switch (currentType)
                    {
                        case "cookies":
                            cookies = numOfSweets;
                            totalSum += numOfSweets * 1.5;
                            break;
                        case "cakes":
                            cakes = numOfSweets;
                            totalSum += numOfSweets * 7.8;
                            break;
                        case "waffles":
                            waffles = numOfSweets;
                            totalSum += numOfSweets * 2.3;
                            break;
                    }
                    currentType = Console.ReadLine();
                }
                Console.WriteLine($"{currentContester} baked {cookies} cookies, {cakes} cakes and {waffles} waffles.");
            }

            Console.WriteLine($"All bakery sold: {allBakery}");
            Console.WriteLine($"Total sum for charity: {totalSum:f2} lv.");
        }
    }
}
