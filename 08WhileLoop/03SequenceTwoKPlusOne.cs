namespace CSharpProgrammingBasics._08WhileLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _03SequenceTwoKPlusOne
    {
        internal static void Start()
        {
            int number = int.Parse(Console.ReadLine());
            int k = 1;

            while (k <= number)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
