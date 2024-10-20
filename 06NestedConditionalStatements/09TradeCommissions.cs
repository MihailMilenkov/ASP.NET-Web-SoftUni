namespace CSharpProgrammingBasics._06NestedConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _09TradeCommissions
    {
        internal static void Start()
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0;
            bool isValid = true;
            if ((town != "Sofia" && town != "Varna" && town != "Plovdiv") || sales < 0)
            {
                Console.WriteLine("error");
            }
            else if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.08;
                }
                else if (sales > 10000)
                {
                    commission = 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                    isValid = false;
                }
                if (isValid)
                {
                    double result = sales * commission;
                    Console.WriteLine($"{result:f2}");
                }
            }
            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.10;
                }
                else if (sales > 10000)
                {
                    commission = 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                    isValid = false;
                }
                if (isValid)
                {
                    double result = sales * commission;
                    Console.WriteLine($"{result:f2}");
                }
            }
            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.12;
                }
                else if (sales > 10000)
                {
                    commission = 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                    isValid = false;
                }
                if (isValid)
                {
                    double result = sales * commission;
                    Console.WriteLine($"{result:f2}");
                }
            }
        }
    }
}
