﻿namespace CSharpProgrammingBasics._08WhileLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _01NumbersFromOneToOneHundred
    {
        internal static void Start()
        {
            int n = int.Parse(Console.ReadLine());

            while (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid Number");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {n}");
        }
    }
}
