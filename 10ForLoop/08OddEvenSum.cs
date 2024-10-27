namespace CSharpProgrammingBasics._10ForLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _08OddEvenSum
    {
        internal static void Start()
        {
            int num = int.Parse(Console.ReadLine());
            int one = 0;
            int two = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    one += int.Parse(Console.ReadLine());
                }
                if (i % 2 == 0)
                {
                    two += int.Parse(Console.ReadLine());
                }
            }

            if (one == two)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {one}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(one - two)}");
            }
        }
    }
}
