namespace CSharpProgrammingBasics._01FirstSteps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _02BasicSyntax
    {
        // See https://aka.ms/new-console-template for more information
        //

        // 1. Age group
        //int age = int.Parse(Console.ReadLine());

        //if (age >= 0 && age <= 2)
        //{
        //    Console.WriteLine("baby");
        //}
        //else if (age <= 13)
        //{
        //    Console.WriteLine("child");
        //}
        //else if (age <= 19)
        //{
        //    Console.WriteLine("teenager");
        //}
        //else if (age <= 65)
        //{
        //    Console.WriteLine("adult");
        //}
        //else if (age >= 66)
        //{
        //    Console.WriteLine("elder");
        //}

        // 2. Division
        //int dividend = int.Parse(Console.ReadLine());

        //if (dividend % 10 == 0)
        //{
        //    Console.WriteLine("The number is divisible by 10");
        //}
        //else if (dividend % 7 == 0)
        //{
        //    Console.WriteLine("The number is divisible by 7");
        //}
        //else if (dividend % 6 == 0)
        //{
        //    Console.WriteLine("The number is divisible by 6");
        //}
        //else if (dividend % 3 == 0)
        //{
        //    Console.WriteLine("The number is divisible by 3");
        //}
        //else if (dividend % 2 == 0)
        //{
        //    Console.WriteLine("The number is divisible by 2");
        //}
        //else
        //{
        //    Console.WriteLine("Not divisible");
        //}

        // 3
        //Vacation();

        //void Vacation()
        //{
        //    Console.WriteLine("Number of people");
        //    int? peopleCount = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Type: Students, Business, Regular");
        //    string? type = Console.ReadLine();
        //    Console.WriteLine("Day: Friday, Saturday, Sunday");
        //    string? day = Console.ReadLine();
        //    decimal pricePerPerson = 0;

        //    switch (type)
        //    {
        //        case "Students":
        //            switch (day)
        //            {
        //                case "Friday":
        //                    pricePerPerson = 8.45M;
        //                    break;
        //                case "Saturday":
        //                    pricePerPerson = 9.80M;
        //                    break;
        //                case "Sunday":
        //                    pricePerPerson = 10.46M;
        //                    break;
        //            }
        //            break;
        //        case "Business":
        //            switch (day)
        //            {
        //                case "Friday":
        //                    pricePerPerson = 10.9M;
        //                    break;
        //                case "Saturday":
        //                    pricePerPerson = 15.60M;
        //                    break;
        //                case "Sunday":
        //                    pricePerPerson = 16;
        //                    break;
        //            }
        //            break;
        //        case "Regular":
        //            switch (day)
        //            {
        //                case "Friday":
        //                    pricePerPerson = 15;
        //                    break;
        //                case "Saturday":
        //                    pricePerPerson = 20;
        //                    break;
        //                case "Sunday":
        //                    pricePerPerson = 22.50M;
        //                    break;
        //            }
        //            break;
        //    }

        //    decimal? totalPrice = pricePerPerson * peopleCount;
        //    if (type == "Students" && peopleCount >= 30)
        //    {
        //        totalPrice *= .85M;
        //    }
        //    if (type == "Business" && peopleCount >= 100)
        //    {
        //        totalPrice -= pricePerPerson * 10;
        //    }

        //    if (type == "Regular" && peopleCount >= 10 && peopleCount <= 20)
        //    {
        //        totalPrice *= .95M;
        //    }
        //    Console.WriteLine($"Total price: {totalPrice:f2}");
        //}
    }
}
