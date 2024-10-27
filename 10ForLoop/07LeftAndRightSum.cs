namespace CSharpProgrammingBasics._10ForLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _07LeftAndRightSum
    {
        internal static void Start()
        {
            int num = int.Parse(Console.ReadLine());
            int one = 0;
            int two = 0;

            for (int i = 1; i <= num; i++)
            {
                one += int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= num; i++)
            {
                two += int.Parse(Console.ReadLine());
            }
            if (one == two)
            {
                Console.WriteLine($"Yes, sum = {one}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(one - two)}");
            }
        }
    }
}
