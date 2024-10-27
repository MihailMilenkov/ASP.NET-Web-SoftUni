namespace CSharpProgrammingBasics._10ForLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _05SumNumbers
    {
        internal static void Start()
        {
            int lines = int.Parse(Console.ReadLine());
            int output = 0;

            for (int i = 0; i < lines; i++)
            {
                int num = int.Parse(Console.ReadLine());
                output += num;
            }

            Console.WriteLine(output);
        }
    }
}
