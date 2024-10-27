namespace CSharpProgrammingBasics._11ForLoopExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _06DivideWithoutRemainder
    {
        internal static void Start()
        {
            int numCount = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double currentNum = 0;
            for (int i = 0; i < numCount; i++)
            {
                currentNum = double.Parse(Console.ReadLine());
                if (currentNum % 2 == 0)
                {
                    p1++;
                }
                if (currentNum % 3 == 0)
                {
                    p2++;
                }
                if (currentNum % 4 == 0)
                {
                    p3++;
                }
            }

            double p1Percent = p1 / numCount * 100;
            double p2Percent = p2 / numCount * 100;
            double p3Percent = p3 / numCount * 100;

            Console.WriteLine($"{p1Percent:f2}%");
            Console.WriteLine($"{p2Percent:f2}%");
            Console.WriteLine($"{p3Percent:f2}%");
        }
    }
}
