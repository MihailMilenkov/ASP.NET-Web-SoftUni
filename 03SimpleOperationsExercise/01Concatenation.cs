namespace CSharpProgrammingBasics._03SimpleOperationsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _01Concatenation
    {
        internal static void Start()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double sum = num1 + num2;

            Console.WriteLine(num1 + "+" + num2 + "=" + sum);
        }
    }
}
