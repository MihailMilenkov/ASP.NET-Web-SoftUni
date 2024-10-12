namespace CSharpProgrammingBasics._04ConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _06PasswordGuesss
    {
        internal static void Start()
        {
            string input = Console.ReadLine();
            string pass = "s3cr3t!P@ssw0rd";
            if (input == pass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
