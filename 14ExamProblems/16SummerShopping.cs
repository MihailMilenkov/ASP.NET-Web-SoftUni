namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _16SummerShopping
    {
        internal static void Start()
        {
            double budget = double.Parse(Console.ReadLine());
            double towelPrice = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double umbrellaPrice = towelPrice * 2 / 3;
            double flipFlopsPrice = umbrellaPrice * .75;
            double beachBag = (towelPrice + flipFlopsPrice) * 1 / 3;
            double costWithoutDiscount = (towelPrice + umbrellaPrice + flipFlopsPrice + beachBag);
            double cost = costWithoutDiscount - ((percentDiscount / 100) * costWithoutDiscount);

            if (budget >= cost)
            {
                Console.WriteLine($"Annie's sum is {cost:f2} lv. She has {budget - cost:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {cost:f2} lv. She needs {cost - budget:f2} lv. more.");
            }
        }
    }
}
