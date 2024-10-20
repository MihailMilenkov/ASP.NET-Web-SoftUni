namespace CSharpProgrammingBasics._07NestedConditionalStatementsEcercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _06Journey
    {
        internal static void Start()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string destination = "";
            string type = "";


            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        price = budget * 0.3;
                        break;
                    case "winter":
                        price = budget * 0.7;
                        break;
                }
            }

            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        price = budget * 0.4;
                        break;
                    case "winter":
                        price = budget * 0.8;
                        break;
                }
            }

            else if (budget > 1000)
            {
                destination = "Europe";
                price = budget * 0.9;
            }

            if (season == "summer" && destination != "Europe")
            {
                type = "Camp";
            }
            if (destination == "Europe" || season == "winter")
            {
                type = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {price:f2}");
        }
    }
}
