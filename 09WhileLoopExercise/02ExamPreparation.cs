namespace CSharpProgrammingBasics._09WhileLoopExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _02ExamPreparation
    {
        internal static void Start()
        {
            int maxFailedGrades = int.Parse(Console.ReadLine());
            string task = Console.ReadLine();
            int currentGrade = int.Parse(Console.ReadLine());
            int failedGrades = 0;
            double totalGrade = 0;
            double countGrade = 0;
            string lastProblem = "";

            while (task != "Enough")
            {
                if (currentGrade <= 4)
                {
                    failedGrades++;
                    if (failedGrades == maxFailedGrades)
                    {
                        Console.WriteLine($"You need a break, {failedGrades} poor grades.");
                        break;
                    }
                }
                countGrade++;
                totalGrade += currentGrade;
                lastProblem = task;
                task = Console.ReadLine();
                if (task == "Enough")
                {
                    break;
                }
                currentGrade = int.Parse(Console.ReadLine());
            }

            if (task == "Enough")
            {
                Console.WriteLine($"Average score: {totalGrade / countGrade:f2}");
                Console.WriteLine($"Number of problems: {countGrade}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
