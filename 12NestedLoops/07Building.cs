﻿namespace CSharpProgrammingBasics._12NestedLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _07Building
    {
        internal static void Start()
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int floor = floors; floor > 0; floor--)
            {
                for (int room = 0; room < rooms; room++)
                {
                    if (floor == floors)
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
