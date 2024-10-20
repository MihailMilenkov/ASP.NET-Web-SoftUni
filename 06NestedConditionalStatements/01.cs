namespace CSharpProgrammingBasics._06NestedConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _01
    {
        internal static void Start()
        {
            string input = Console.ReadLine();

            bool check = (input == "banana" || input == "apple" || input == "kiwi" || input == "cherry" || input == "lemon" || input == "grapes");

            Console.WriteLine(check);
        }
    }
}
