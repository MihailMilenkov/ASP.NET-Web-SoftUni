namespace CSharpProgrammingBasics._07NestedConditionalStatementsEcercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _04NewHouse
    {
        internal static void Start()
        {
            string flowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double price = 0;

            //double rosesPrice = 5;
            //double rosesDahlias = 3.8;
            //double rosesTulips = 2.8;
            //double rosesNarcissus = 3;
            //double rosesGladiolus = 2.5;

            switch (flowers)
            {
                case "Roses":
                    price = numberOfFlowers * 5;
                    if (numberOfFlowers > 80)
                    {
                        price *= 0.9;
                    }
                    break;
                case "Dahlias":
                    price = numberOfFlowers * 3.8;
                    if (numberOfFlowers > 90)
                    {
                        price *= 0.85;
                    }
                    break;
                case "Tulips":
                    price = numberOfFlowers * 2.8;
                    if (numberOfFlowers > 80)
                    {
                        price *= 0.85;
                    }
                    break;

                case "Narcissus":
                    price = numberOfFlowers * 3;
                    if (numberOfFlowers < 120)
                    {
                        price *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    price = numberOfFlowers * 2.5;
                    if (numberOfFlowers < 80)
                    {
                        price *= 1.2;
                    }
                    break;
            }

            double diff = Math.Abs(budget - price);

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowers} and {diff:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {diff:f2} leva more.");
            }
        }
    }
}
