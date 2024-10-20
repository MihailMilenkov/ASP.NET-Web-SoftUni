namespace CSharpProgrammingBasics._06NestedConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _05NumberInRange
    {
        internal static void Start()
        {
            double num = double.Parse(Console.ReadLine());

            // [-100 , 100] and num !=0

            if (num >= -100 && num <= 100 && num != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
