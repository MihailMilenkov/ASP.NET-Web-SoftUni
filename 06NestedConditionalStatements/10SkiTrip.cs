namespace CSharpProgrammingBasics._06NestedConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _10SkiTrip
    {
        internal static void Start()
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double priceForOneNight = 0;
            double discount = 0;

            switch (roomType)
            {
                case "room for one person":
                    priceForOneNight = 18;
                    break;
                case "apartment":
                    priceForOneNight = 25;
                    if (days < 10)
                    {
                        discount = 0.30;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.35;
                    }
                    else if (days > 15)
                    {
                        discount = 0.5;
                    }
                    break;
                case "president apartment":
                    priceForOneNight = 35;
                    if (days < 10)
                    {
                        discount = 0.10;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.15;
                    }
                    else if (days > 15)
                    {
                        discount = 0.20;
                    }
                    break;
            }

            int nights = days - 1;
            double totalPrice = nights * priceForOneNight;
            totalPrice -= totalPrice * discount;

            if (feedback == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else if (feedback == "negative")
            {
                totalPrice -= totalPrice * 0.1;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
