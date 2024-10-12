namespace CSharpProgrammingBasics._04ConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _00ConditionalStatements1
    {
        internal static void Start()
        {
            static void Main(string[] args)
            {
                string password = Console.ReadLine();
                string ourPassword = "123";

                if (password == ourPassword)
                {
                    Console.WriteLine("Bravo");
                }
                else
                {
                    Console.WriteLine("Please try again");
                }
            }
        }
    }
}
