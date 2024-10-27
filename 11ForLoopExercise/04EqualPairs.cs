namespace CSharpProgrammingBasics._11ForLoopExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _04EqualPairs
    {
        internal static void Start()
        {
            int numPairs = int.Parse(Console.ReadLine());
            double currentSum = 0;
            double lastSum = 0;
            double diff = 0;
            int counter = 0;


            for (int i = 1; i <= numPairs; i++)
            {
                counter++;
                double firstNum = double.Parse(Console.ReadLine());
                double secondNum = double.Parse(Console.ReadLine());
                currentSum = firstNum + secondNum;
                diff = Math.Abs(currentSum - lastSum);
                lastSum = currentSum;
            }

            if (diff == 0 || counter <= 1)
            {
                Console.WriteLine($"Yes, value={lastSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }
        }
    }
}
