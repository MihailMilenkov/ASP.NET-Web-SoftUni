namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _15Reservation
    {
        internal static void Start()
        {
            double reservationDay = double.Parse(Console.ReadLine());
            double reservationMonth = double.Parse(Console.ReadLine());
            double settleDay = double.Parse(Console.ReadLine());
            double settleMonth = double.Parse(Console.ReadLine());
            double departureDay = double.Parse(Console.ReadLine());
            double departureMonth = double.Parse(Console.ReadLine());

            double costPerDay = 30;
            if (settleDay - reservationDay > 10)
            {
                costPerDay = 25;
            }
            if (settleMonth > reservationMonth)
            {
                costPerDay = 20;
            }
            double cost = (departureDay - settleDay) * costPerDay;

            Console.WriteLine($"Your stay from {settleDay}/{settleMonth} to {departureDay}/{departureMonth} will cost {cost:f2}");
        }
    }
}