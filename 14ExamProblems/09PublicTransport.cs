namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _09PublicTransport
    {
        internal static void Start()
        {
            string line = Console.ReadLine();
            string season = Console.ReadLine();
            double travelTime = 0;

            switch (season)
            {
                case "Summer":
                    Console.WriteLine("No lectures! It's summer!");
                    break;
                case "Spring":
                    switch (line)
                    {
                        case "208":
                            travelTime = 57;
                            break;
                        case "15":
                            travelTime = 57;
                            break;
                        case "240":
                            travelTime = 49;
                            break;
                        case "Subway":
                            travelTime = 56;
                            break;
                    }
                    break;
                case "Autumn":
                    switch (line)
                    {
                        case "208":
                            travelTime = 63;
                            break;
                        case "15":
                            travelTime = 63;
                            break;
                        case "240":
                            travelTime = 55;
                            break;
                        case "Subway":
                            travelTime = 56;
                            break;
                    }
                    break;
                case "Winter":
                    switch (line)
                    {
                        case "208":
                            travelTime = 83;
                            break;
                        case "15":
                            travelTime = 78;
                            break;
                        case "240":
                            travelTime = 66;
                            break;
                        case "Subway":
                            travelTime = 56;
                            break;
                    }
                    break;
            }

            if (season != "Summer")
            {
                Console.WriteLine($"Total travel time: {travelTime} minutes");
            }
        }
    }
}
