namespace CSharpProgrammingBasics._06NestedConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _00
    {
        internal static void Start()
        {
            // sunny cloudy snowy rainy

            string weather = Console.ReadLine();

            //if (weather == "sunny")
            //{
            //    Console.WriteLine("The weather is sunny");
            //}
            //else if (weather == "cloudy")
            //{
            //    Console.WriteLine("The weather is cloudy");
            //}
            //else if (weather == "snowy")
            //{
            //    Console.WriteLine("The weather is snowy");
            //}
            //else if (weather == "rainy")
            //{
            //    Console.WriteLine("The weather is rainy");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}

            switch (weather)
            {
                case "sunny":
                    Console.WriteLine("The weather is sunny");
                    break;
                case "cloudy":
                    Console.WriteLine("The weather is cloudy");
                    break;
                case "snowy":
                    Console.WriteLine("The weather is snowy");
                    break;
                case "rainy":
                    Console.WriteLine("The weather is rainy");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
