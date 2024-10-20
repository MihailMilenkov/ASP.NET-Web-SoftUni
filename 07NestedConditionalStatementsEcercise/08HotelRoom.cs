namespace CSharpProgrammingBasics._07NestedConditionalStatementsEcercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _08HotelRoom
    {
        internal static void Start()
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            double priceAp = 0;
            double priceSt = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceAp = 65;
                    priceSt = 50;
                    break;
                case "June":
                case "September":
                    priceAp = 68.70;
                    priceSt = 75.20;
                    break;
                case "July":
                case "August":
                    priceAp = 77;
                    priceSt = 76;
                    break;
            }

            if (((month == "May") || (month == "October")) && nights > 14)
            {
                priceSt *= 0.7;
            }
            else if (((month == "May") || (month == "October")) && nights > 7)
            {
                priceSt *= 0.95;
            }
            else if (((month == "June") || (month == "September")) && nights > 14)
            {
                priceSt *= 0.8;
            }

            if (nights > 14)
            {
                priceAp *= 0.9;
            }

            double priceApT = priceAp * nights;
            double priceStT = priceSt * nights;

            Console.WriteLine($"Apartment: {priceApT:f2} lv.");
            Console.WriteLine($"Studio: {priceStT:f2} lv.");
        }
    }
}
