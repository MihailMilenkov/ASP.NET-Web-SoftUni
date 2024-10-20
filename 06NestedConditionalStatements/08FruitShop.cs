namespace CSharpProgrammingBasics._06NestedConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _08FruitShop
    {
        internal static void Start()
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if ((fruit != "banana" && fruit != "apple" && fruit != "orange" && fruit != "grapefruit" && fruit != "kiwi" && fruit != "pineapple" && fruit != "grapes") || (day != "Monday" && day != "Tuesday" && day != "Wednesday" && day != "Thursday" && day != "Friday" && day != "Saturday" && day != "Sunday"))
            {
                Console.WriteLine("error");
            }
            else if (fruit == "banana")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 2.5;
                        break;
                }
                switch (day)
                {
                    case "Saturday":
                    case "Sunday":
                        price = 2.7;
                        break;
                }
                Console.WriteLine($"{(quantity * price):f2}");
            }
            else if (fruit == "apple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 1.2;
                        break;
                }
                switch (day)
                {
                    case "Saturday":
                    case "Sunday":
                        price = 1.25;
                        break;
                }
                Console.WriteLine($"{(quantity * price):f2}");
            }
            else if (fruit == "orange")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 0.85;
                        break;
                }
                switch (day)
                {
                    case "Saturday":
                    case "Sunday":
                        price = 0.9;
                        break;
                }
                Console.WriteLine($"{(quantity * price):f2}");
            }
            else if (fruit == "grapefruit")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 1.45;
                        break;
                }
                switch (day)
                {
                    case "Saturday":
                    case "Sunday":
                        price = 1.6;
                        break;
                }
                Console.WriteLine($"{(quantity * price):f2}");
            }
            else if (fruit == "kiwi")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 2.7;
                        break;
                }
                switch (day)
                {
                    case "Saturday":
                    case "Sunday":
                        price = 3;
                        break;
                }
                Console.WriteLine($"{(quantity * price):f2}");
            }
            else if (fruit == "pineapple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 5.5;
                        break;
                }
                switch (day)
                {
                    case "Saturday":
                    case "Sunday":
                        price = 5.6;
                        break;
                }
                Console.WriteLine($"{(quantity * price):f2}");
            }
            else if (fruit == "grapes")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 3.85;
                        break;
                }
                switch (day)
                {
                    case "Saturday":
                    case "Sunday":
                        price = 4.2;
                        break;
                }
                Console.WriteLine($"{(quantity * price):f2}");
            }
        }
    }
}
