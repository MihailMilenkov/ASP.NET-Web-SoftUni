namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _11AirplaneSeats
    {
        internal static void Start()
        {
            double totalMen = double.Parse(Console.ReadLine());
            double menNextToWindow = 0;
            double menInTheMiddle = 0;
            double menNextToPathway = 0;

            for (int i = 1; i <= totalMen; i++)
            {
                string seatNum = Console.ReadLine();
                char currentType = seatNum[1];
                if (currentType == 'A' || currentType == 'F')
                {
                    menNextToWindow++;
                }
                if (currentType == 'B' || currentType == 'E')
                {
                    menInTheMiddle++;
                }
                if (currentType == 'C' || currentType == 'D')
                {
                    menNextToPathway++;
                }

            }

            double windowPercent = 0;
            double middlePercent = 0;
            double pathwayPercent = 0;

            if (menNextToWindow > 0)
            {
                windowPercent = (menNextToWindow / totalMen) * 100;
            }
            if (menInTheMiddle > 0)
            {
                middlePercent = (menInTheMiddle / totalMen) * 100;
            }
            if (menNextToPathway > 0)
            {
                pathwayPercent = (menNextToPathway / totalMen) * 100;
            }

            Console.WriteLine($"Window Seats: {windowPercent:f2}%");
            Console.WriteLine($"Middle Seats: {middlePercent:f2}%");
            Console.WriteLine($"Aisle Seats: {pathwayPercent:f2}%");
        }
    }
}
