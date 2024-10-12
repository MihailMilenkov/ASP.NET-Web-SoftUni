namespace CSharpProgrammingBasics._04ConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _03EvenOrOdd
    {
        internal static void Start()
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else if (num % 2 == 1)
            {
                Console.WriteLine("odd");
            }
        }
    }
}
