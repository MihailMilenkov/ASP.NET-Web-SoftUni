namespace CSharpProgrammingBasics._08WhileLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _07Graduation
    {
        internal static void Start()
        {
            string name = Console.ReadLine();
            double successfulClassCount = 0;
            double totalGrade = 0;
            double classTaken = 0;

            while (successfulClassCount < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    successfulClassCount++;
                    totalGrade += grade;
                    classTaken++;
                }
            }

            Console.WriteLine($"{name} graduated. Average grade: {totalGrade / classTaken:f2}");
        }
    }
}
