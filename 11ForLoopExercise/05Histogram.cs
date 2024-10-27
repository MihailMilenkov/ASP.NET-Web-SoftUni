namespace CSharpProgrammingBasics._11ForLoopExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _05Histogram
    {
        internal static void Start()
        {
            int numCount = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            int currentNum = 0;

            for (int i = 0; i < numCount; i++)
            {
                currentNum = int.Parse(Console.ReadLine());
                if (currentNum < 200)
                {
                    p1++;
                }
                else if (currentNum >= 200 && currentNum < 400)
                {
                    p2++;
                }
                else if (currentNum >= 400 && currentNum < 600)
                {
                    p3++;
                }
                else if (currentNum >= 600 && currentNum < 800)
                {
                    p4++;
                }
                else if (currentNum >= 800)
                {
                    p5++;
                }
            }

            double p1Percent = p1 / numCount * 100;
            double p2Percent = p2 / numCount * 100;
            double p3Percent = p3 / numCount * 100;
            double p4Percent = p4 / numCount * 100;
            double p5Percent = p5 / numCount * 100;

            Console.WriteLine($"{p1Percent:f2}%");
            Console.WriteLine($"{p2Percent:f2}%");
            Console.WriteLine($"{p3Percent:f2}%");
            Console.WriteLine($"{p4Percent:f2}%");
            Console.WriteLine($"{p5Percent:f2}%");
        }
    }
}
