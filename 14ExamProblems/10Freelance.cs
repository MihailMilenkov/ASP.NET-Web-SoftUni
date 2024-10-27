namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _10Freelance
    {
        internal static void Start()
        {
            double goal = double.Parse(Console.ReadLine());
            double monthlyExpenses = double.Parse(Console.ReadLine());
            double currentMoney = 0;
            double months = 0;

            while (currentMoney > 0 || currentMoney < goal)
            {
                months++;
                currentMoney -= monthlyExpenses;
                currentMoney += double.Parse(Console.ReadLine());
                if (currentMoney < 0)
                {
                    Console.WriteLine("It seems you have bankrupted...");
                    if (months < 12)
                    {
                        Console.WriteLine($"You have worked {Math.Floor(months / 12)} years {months} months");
                    }
                    else
                    {
                        Console.WriteLine($"You have worked {Math.Floor(months / 12)} years {months % 12} months");
                    }
                    break;
                }
                if (currentMoney >= goal)
                {
                    Console.WriteLine("You did it!");
                    if (months < 12)
                    {
                        Console.WriteLine($"It took you {Math.Floor(months / 12)} years {months} months");
                    }
                    else
                    {
                        Console.WriteLine($"It took you {Math.Floor(months / 12)} years {months % 12} months");
                    }
                    break;
                }
            }
        }
    }
}
