namespace CSharpProgrammingBasics._11ForLoopExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _02HalfSumElement
    {
        internal static void Start()
        {
            int numCount = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int total = 0;

            for (int i = 0; i < numCount; i++)
            {
                int num = int.Parse(Console.ReadLine());
                total += num;
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            int totalWithoutMax = total - maxNum;

            if (totalWithoutMax == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNum);
            }
            else
            {
                int diff = Math.Abs(maxNum - totalWithoutMax);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
