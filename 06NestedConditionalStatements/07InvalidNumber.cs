namespace CSharpProgrammingBasics._06NestedConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _07InvalidNumber
    {
        internal static void Start()
        {
            double num = double.Parse(Console.ReadLine());
            bool invalid = ((num < 100 || num > 200) && num != 0);


            if (invalid == true)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
