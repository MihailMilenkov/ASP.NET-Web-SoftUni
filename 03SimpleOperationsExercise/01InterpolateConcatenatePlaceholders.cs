namespace CSharpProgrammingBasics._03SimpleOperationsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _01InterpolateConcatenatePlaceholders
    {
        internal static void Start()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;

            // num1 + num2 = sum;
            // interpolation:

            Console.WriteLine($"{num1} + {num2} = {sum}");

            //concatenation:
            Console.WriteLine(num1 + "+" + num2 + "=" + sum);

            //placeholders:
            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
        }
    }
}
