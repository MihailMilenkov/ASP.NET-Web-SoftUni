namespace CSharpProgrammingBasics._10ForLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _09NumbersNTo1
    {
        internal static void Start()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = num; num >= 1; num--)
            {
                Console.WriteLine(num);
            }
        }
    }
}
