namespace CSharpProgrammingBasics._05ConditionalStatementsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _001
    {
        internal static void Start()
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= 5)
            {
                Console.WriteLine("Less than or equal to 5");
            }
            else if (num <= 10)
            {
                Console.WriteLine("Less than or equal to 10");
            }
        }
    }
}
