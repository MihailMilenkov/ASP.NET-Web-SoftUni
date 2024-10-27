namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _12PassengersPerFlight
    {
        internal static void Start()
        {
            int companiesCount = int.Parse(Console.ReadLine());
            string companyWithMostAverageFlights = "";
            double mostAveragePersons = 0;

            for (int i = 0; i < companiesCount; i++)
            {
                string currentCompany = Console.ReadLine();

                string numOfCurrentPassengersAsString = Console.ReadLine();
                double numOfCurrentPassengers = 0;
                double numOfFlights = 0;

                while (numOfCurrentPassengersAsString != "Finish")
                {
                    numOfCurrentPassengers += double.Parse(numOfCurrentPassengersAsString);
                    numOfFlights++;


                    numOfCurrentPassengersAsString = Console.ReadLine();
                }
                if (numOfCurrentPassengers / numOfFlights > mostAveragePersons)
                {
                    mostAveragePersons = numOfCurrentPassengers / numOfFlights;
                    companyWithMostAverageFlights = currentCompany;
                }

                Console.WriteLine($"{currentCompany}: {Math.Floor(numOfCurrentPassengers / numOfFlights)} passengers.");
            }

            Console.WriteLine($"{companyWithMostAverageFlights} has most passengers per flight: {Math.Floor(mostAveragePersons)}");
        }
    }
}
