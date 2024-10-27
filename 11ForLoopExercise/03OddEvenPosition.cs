namespace CSharpProgrammingBasics._11ForLoopExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _03OddEvenPosition
    {
        internal static void Start()
        {
            int numCount = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double currentNum = 0;
            int oddCounter = 0;
            int evenCounter = 0;


            for (int i = 1; i <= numCount; i++)
            {
                currentNum = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenCounter++;
                    evenSum += currentNum;
                    if (currentNum > evenMax)
                    {
                        evenMax = currentNum;
                    }
                    if (currentNum < evenMin)
                    {
                        evenMin = currentNum;
                    }
                }
                if (i % 2 != 0)
                {
                    oddCounter++;
                    oddSum += currentNum;
                    if (currentNum > oddMax)
                    {
                        oddMax = currentNum;
                    }
                    if (currentNum < oddMin)
                    {
                        oddMin = currentNum;
                    }
                }

            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddCounter > 0)
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenCounter > 0)
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
