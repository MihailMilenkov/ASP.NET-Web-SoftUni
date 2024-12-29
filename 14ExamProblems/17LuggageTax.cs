namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _17LuggageTax
    {
        internal static void Start()
        {
            double caseWidth = double.Parse(Console.ReadLine());
            double caseHeight = double.Parse(Console.ReadLine());
            double caseLength = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            double volume = caseWidth * caseHeight * caseLength;

            switch (type)
            {
                case "true":
                    if (volume <= 50)
                    {
                        Console.WriteLine("Luggage tax: 0.00");
                    }
                    else if (volume > 50 && volume <= 100)
                    {
                        Console.WriteLine("Luggage tax: 0.00");
                    }
                    else if (volume > 100 && volume <= 200)
                    {
                        Console.WriteLine("Luggage tax: 10.0");
                    }
                    else if (volume > 200 && volume <= 300)
                    {
                        Console.WriteLine("Luggage tax: 20.00");
                    }
                    break;
                case "false":
                    if (volume <= 50)
                    {
                        Console.WriteLine("Luggage tax: 0.00");
                    }
                    else if (volume > 50 && volume <= 100)
                    {
                        Console.WriteLine("Luggage tax: 25.00");
                    }
                    else if (volume > 100 && volume <= 200)
                    {
                        Console.WriteLine("Luggage tax: 50.00");
                    }
                    else if (volume > 200 && volume <= 300)
                    {
                        Console.WriteLine("Luggage tax: 100.00");
                    }
                    break;
            }
        }
    }
}
