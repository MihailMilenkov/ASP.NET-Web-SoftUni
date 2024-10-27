namespace CSharpProgrammingBasics._13NestedLoopsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _06SumPrimeNonPrime
    {
        internal static void Start()
        {
            string command = Console.ReadLine();
            int num = int.Parse(command);

            while (command != "stop")
            {
                num += int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("Number is negative");
                    continue;
                }
            }

            Console.WriteLine(num);
        }
    }
}
