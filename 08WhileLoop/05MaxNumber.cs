namespace CSharpProgrammingBasics._08WhileLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _05MaxNumber
    {
        internal static void Start()
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int maxNum = int.MinValue;

            while (counter < n)
            {
                int number = int.Parse(Console.ReadLine());
                counter++;

                if (number > maxNum)
                {
                    maxNum = number;
                }
            }

            Console.WriteLine(maxNum);
        }
    }
}
