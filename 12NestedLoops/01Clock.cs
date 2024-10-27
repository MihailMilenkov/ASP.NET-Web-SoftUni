namespace CSharpProgrammingBasics._12NestedLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _01Clock
    {
        internal static void Start()
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    Console.WriteLine($"{i}:{j}");
                }
            }
        }
    }
}
