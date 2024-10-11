namespace CSharpProgrammingBasics._01FirstSteps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Login
    {
        public static void Start()
        {
            string userName = Console.ReadLine();
            string password = string.Empty;
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password = password + userName[i];
            }

            string input = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                if (input == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else
                {
                    if (i == 3)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }

                input = Console.ReadLine();
            }
        }
    }
}