namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _13Savings
    {
        internal static void Start()
        {
            double monthlyIncome = double.Parse(Console.ReadLine());
            double allowedMonths = double.Parse(Console.ReadLine());
            double monthlyFees = double.Parse(Console.ReadLine());

            double monthlySavings = (monthlyIncome * .7) - monthlyFees;
            double monthlyPercentSavings = (monthlySavings / monthlyIncome) * 100;
            double totalSavings = monthlySavings * allowedMonths;

            Console.WriteLine($"She can save {monthlyPercentSavings:f2}%");
            Console.WriteLine($"{totalSavings:f2}");
        }
    }
}
