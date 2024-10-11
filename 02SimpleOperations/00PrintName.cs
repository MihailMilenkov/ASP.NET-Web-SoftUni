namespace CSharpProgrammingBasics._02SimpleOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class PrintName
    {
        public static void Start() 
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            string town = Console.ReadLine();

            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
