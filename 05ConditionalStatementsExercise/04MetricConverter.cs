namespace CSharpProgrammingBasics._05ConditionalStatementsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _04MetricConverter
    {
        internal static void Start()
        {
            double num = double.Parse(Console.ReadLine()); //40
            string input = Console.ReadLine();             // m
            string output = Console.ReadLine();            // cm

            // m cm mm

            if (input == "cm")
            {
                num = num / 100;
            }
            else if (input == "mm")
            {
                num = num / 1000;
            }
            else if (input == "m")
            {
                num = num * 1;
            }

            if (output == "cm")
            {
                num *= 100;
                Console.WriteLine($"{num:f3}");
            }
            else if (output == "mm")
            {
                num *= 1000;
                Console.WriteLine($"{num:f3}");
            }
            else if (output == "m")
            {
                Console.WriteLine($"{num:f3}");
            }
        }
    }
}
