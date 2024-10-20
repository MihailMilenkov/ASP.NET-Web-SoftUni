namespace CSharpProgrammingBasics._07NestedConditionalStatementsEcercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _10Volleyball
    {
        internal static void Start()
        {
            string type = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double weekends = 48;
            double sofiaPlay = (weekends - h) * 3 / 4;

            double result = (p * 2 / 3) + sofiaPlay + h;

            if (type == "normal")
            {
                Console.WriteLine($"{Math.Floor(result)}");
            }
            else if (type == "leap")
            {
                Console.WriteLine($"{Math.Floor(result *= 1.15)}");
            }

        }
    }
}
