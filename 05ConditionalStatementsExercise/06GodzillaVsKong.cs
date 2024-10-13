namespace CSharpProgrammingBasics._05ConditionalStatementsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _06GodzillaVsKong
    {
        internal static void Start()
        {
            double budget = double.Parse(Console.ReadLine());
            double massPcs = double.Parse(Console.ReadLine());
            double pricePerMass = double.Parse(Console.ReadLine());
            double decoration = budget * 0.1;
            double clothes = (massPcs * pricePerMass);

            if (massPcs > 150)
            {
                clothes *= 0.9;
            }

            double cost = clothes + decoration;

            if (budget >= cost)
            {
                double excess = budget - cost;
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {excess:f2} leva left.");
            }
            else if (budget < cost)
            {
                double moneyNedded = cost - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNedded:f2} leva more.");
            }
        }
    }
}
