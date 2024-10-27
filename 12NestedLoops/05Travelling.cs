namespace CSharpProgrammingBasics._12NestedLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _05Travelling
    {
        internal static void Start()
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double neededMoney = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < neededMoney)
                {
                    double currentlySaved = double.Parse(Console.ReadLine());
                    savedMoney += currentlySaved;
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
