namespace CSharpProgrammingBasics._10ForLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _001ForLoop
    {
        internal static void Start()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
        }
    }
}
