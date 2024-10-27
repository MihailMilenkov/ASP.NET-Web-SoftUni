namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _03SushiTime
    {
        internal static void Start()
        {
            string sushiType = Console.ReadLine();
            string restaurantName = Console.ReadLine();
            double servings = double.Parse(Console.ReadLine());
            char orderForHome = char.Parse(Console.ReadLine());
            double pricePerMeal = 0;

            switch (sushiType)
            {
                case "sashimi":
                    switch (restaurantName)
                    {
                        case "Sushi Zone":
                            pricePerMeal = 4.99;
                            break;
                        case "Sushi Time":
                            pricePerMeal = 5.49;
                            break;
                        case "Sushi Bar":
                            pricePerMeal = 5.25;
                            break;
                        case "Asian Pub":
                            pricePerMeal = 4.50;
                            break;
                    }
                    break;

                case "maki":
                    switch (restaurantName)
                    {
                        case "Sushi Zone":
                            pricePerMeal = 5.29;
                            break;
                        case "Sushi Time":
                            pricePerMeal = 4.69;
                            break;
                        case "Sushi Bar":
                            pricePerMeal = 5.55;
                            break;
                        case "Asian Pub":
                            pricePerMeal = 4.80;
                            break;
                    }
                    break;

                case "uramaki":
                    switch (restaurantName)
                    {
                        case "Sushi Zone":
                            pricePerMeal = 5.99;
                            break;
                        case "Sushi Time":
                            pricePerMeal = 4.49;
                            break;
                        case "Sushi Bar":
                            pricePerMeal = 6.25;
                            break;
                        case "Asian Pub":
                            pricePerMeal = 5.50;
                            break;
                    }
                    break;

                case "temaki":
                    switch (restaurantName)
                    {
                        case "Sushi Zone":
                            pricePerMeal = 4.29;
                            break;
                        case "Sushi Time":
                            pricePerMeal = 5.19;
                            break;
                        case "Sushi Bar":
                            pricePerMeal = 4.75;
                            break;
                        case "Asian Pub":
                            pricePerMeal = 5.50;
                            break;
                    }
                    break;
            }

            double total = servings * pricePerMeal;

            if (orderForHome == 'Y')
            {
                total *= 1.2;
            }

            if (restaurantName != "Sushi Zone" && restaurantName != "Sushi Time" && restaurantName != "Sushi Bar" && restaurantName != "Asian Pub")
            {
                Console.WriteLine($"{restaurantName} is invalid restaurant!");
            }
            else
            {
                Console.WriteLine($"Total price: {Math.Ceiling(total)} lv.");
            }
        }
    }
}
