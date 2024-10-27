namespace CSharpProgrammingBasics._12NestedLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _09CinemaTickets
    {
        internal static void Start()
        {
            string movie = Console.ReadLine();
            int totalStandartTicketCount = 0;
            int totalStudentTicketCount = 0;
            int totalKidTicketCount = 0;

            while (movie != "Finish")
            {
                int totalCount = int.Parse(Console.ReadLine());
                int count = 0;

                string ticketType = Console.ReadLine();
                while (ticketType != "End")
                {
                    count++;
                    switch (ticketType)
                    {
                        case "standard":
                            totalStandartTicketCount++;
                            break;
                        case "student":
                            totalStudentTicketCount++;
                            break;
                        case "kid":
                            totalKidTicketCount++;
                            break;
                    }

                    if (count == totalCount)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }

                double percentage = count * 1.0 / totalCount * 100;
                Console.WriteLine($"{movie} - {percentage:f2}% full.");
                movie = Console.ReadLine();
            }

            int totalTicketCounT = totalStandartTicketCount + totalKidTicketCount + totalStudentTicketCount;
            double studentPercentage = totalStudentTicketCount * 1.0 / totalTicketCounT * 100;
            double standartPercentage = totalStandartTicketCount * 1.0 / totalTicketCounT * 100;
            double kidPercentage = totalKidTicketCount * 1.0 / totalTicketCounT * 100;

            Console.WriteLine($"Total tickets: {totalTicketCounT}");
            Console.WriteLine($"{studentPercentage:f2}% student tickets.");
            Console.WriteLine($"{standartPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidPercentage:f2}% kids tickets.");
        }
    }
}
