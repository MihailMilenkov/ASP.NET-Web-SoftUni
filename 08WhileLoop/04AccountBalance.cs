namespace CSharpProgrammingBasics._08WhileLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _04AccountBalance
    {
        internal static void Start()
        {
            int numOfOperations = int.Parse(Console.ReadLine());
            int counter = 0;
            double total = 0;

            while (counter < numOfOperations)
            {
                double deposit = double.Parse(Console.ReadLine());
                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {deposit:f2}");
                counter++;
                total += deposit;
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
