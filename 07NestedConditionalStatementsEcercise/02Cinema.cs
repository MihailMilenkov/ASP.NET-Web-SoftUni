namespace CSharpProgrammingBasics._07NestedConditionalStatementsEcercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _02Cinema
    {
        internal static void Start()
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double result = 0;

            switch (type)
            {
                case "Premiere":
                    result = 12 * r * c;
                    Console.WriteLine($"{result:f2}");
                    break;
                case "Normal":
                    result = 7.5 * r * c;
                    Console.WriteLine($"{result:f2}");
                    break;
                case "Discount":
                    result = 5 * r * c;
                    Console.WriteLine($"{result:f2}");
                    break;
            }
        }
    }
}
