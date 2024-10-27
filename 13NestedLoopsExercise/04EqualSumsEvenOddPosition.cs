namespace CSharpProgrammingBasics._13NestedLoopsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _04EqualSumsEvenOddPosition
    {
        internal static void Start()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int num = i;
                int evenSum = 0;
                int oddSum = 0;
                int counter = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                    num /= 10;
                    counter++;

                    if (counter % 2 == 0)
                    {
                        oddSum += digit;
                    }
                    else
                    {
                        evenSum += digit;
                    }
                }

                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
