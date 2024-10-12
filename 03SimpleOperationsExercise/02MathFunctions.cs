namespace CSharpProgrammingBasics._03SimpleOperationsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _02MathFunctions
    {
        internal static void Start()
        {
            double num = 5.6672000000;
            Console.WriteLine(Math.Round(num, 5));
            //Console.WriteLine(Math.Floor(num, 6));
            //Console.WriteLine(Math.Ceiling(num, 8));

            Console.WriteLine($"{num:f5}");

            // CTRL + K + C - comment
            // CTRL + K + U - uncomment
            // CTRL + D copy current line
        }
    }
}
