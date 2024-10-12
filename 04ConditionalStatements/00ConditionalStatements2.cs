namespace CSharpProgrammingBasics._04ConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _00ConditionalStatements2
    {
        internal static void Start()
        {
            int a = 7;

            if (a > 4)
            {
                Console.WriteLine("a is bigger than 4");
            }


            else if (a > 3)
            {
                Console.WriteLine($"a is bigger than 3");
            }

            else
            {
                Console.WriteLine($"a is smaller");
            }
        }
    }
}
