namespace CSharpProgrammingBasics._12NestedLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _02MultiplicationTable
    {
        internal static void Start()
        {
            for (int a = 1; a < 11; a++)
            {
                for (int b = 1; b < 11; b++)
                {
                    Console.WriteLine($"{a} * {b} = {a * b}");
                }
            }
        }
    }
}
