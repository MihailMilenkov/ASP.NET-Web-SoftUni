namespace CSharpProgrammingBasics._11ForLoopExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _07Salary
    {
        internal static void Start()
        {
            int openedTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i <= openedTabs; i++)
            {
                string webSite = Console.ReadLine();
                switch (webSite)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                else if (salary > 0 && i == openedTabs)
                {
                    Console.WriteLine($"{salary}");
                }
            }
        }
    }
}
