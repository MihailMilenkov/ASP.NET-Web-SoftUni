namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _18TripExpenses
    {
        internal static void Start()
        {
            double totalDays = double.Parse(Console.ReadLine());
            double yesterdayMoney = 0;
            for (int i = 1; i <= totalDays; i++)
            {
                double todayMoney = 60 + yesterdayMoney;

                while (todayMoney > 0)
                {
                    string expenseAsString = Console.ReadLine();
                    double expense = double.Parse(expenseAsString);

                    if (todayMoney - expense <= 0)
                    {

                    }

                }
            }
        }
    }
}
