namespace CSharpProgrammingBasics._10ForLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _11EvenPowersOfTwo
    {
        internal static void Start()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i += 2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
