namespace CSharpProgrammingBasics._07NestedConditionalStatementsEcercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _03SummerOutfit
    {
        internal static void Start()
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if (10 <= degrees && degrees <= 18)
            {
                switch (time)
                {
                    case "Morning":
                        Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");
                        break;
                    case "Afternoon":
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                        break;
                    case "Evening":
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                        break;
                }
            }

            else if (18 < degrees && degrees <= 24)
            {
                switch (time)
                {
                    case "Morning":
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                        break;
                    case "Afternoon":
                        Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                        break;
                    case "Evening":
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                        break;
                }
            }

            else if (25 <= degrees)
            {
                switch (time)
                {
                    case "Morning":
                        Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                        break;
                    case "Afternoon":
                        Console.WriteLine($"It's {degrees} degrees, get your Swim Suit and Barefoot.");
                        break;
                    case "Evening":
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                        break;
                }
            }
        }
    }
}
