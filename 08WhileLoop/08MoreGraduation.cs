namespace CSharpProgrammingBasics._08WhileLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _08MoreGraduation
    {
        internal static void Start()
        {
            string name = Console.ReadLine();
            double failCounter = 0;
            double classCounter = 1;
            double gradeTotal = 0;

            while (classCounter < 13)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    gradeTotal += grade;
                    classCounter++;
                }
                else
                {
                    failCounter++;
                    if (failCounter > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {classCounter} grade");
                        break;
                    }
                }

                if (classCounter > 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {gradeTotal / (classCounter - 1):f2}");
                }
            }
        }
    }
}
