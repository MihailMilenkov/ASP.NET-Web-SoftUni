namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _14LemonadeStand
    {
        internal static void Start()
        {
            double kgsLemons = double.Parse(Console.ReadLine());
            double kgsSugar = double.Parse(Console.ReadLine());
            double litersWater = double.Parse(Console.ReadLine());


            double totalJuiceCups = Math.Floor(((kgsLemons * 980) + (.3 * kgsSugar) + (litersWater * 1000)) / 150);

            Console.WriteLine($"All cups sold: {totalJuiceCups:f0}");
            Console.WriteLine($"Money earned: {totalJuiceCups * 1.2:f2}");
        }
    }
}
