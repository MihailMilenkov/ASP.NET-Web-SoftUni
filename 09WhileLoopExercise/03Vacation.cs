namespace CSharpProgrammingBasics._09WhileLoopExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _03Vacation
    {
        internal static void Start()
        {
            double cost = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int consecutiveDays = 0;
            int days = 0;

            while (money < cost)
            {
                string type = Console.ReadLine();
                double num = double.Parse(Console.ReadLine());
                if (type == "spend")
                {
                    money -= num;
                    if (money < 0)
                    {
                        money = 0;
                    }
                    consecutiveDays++;
                    days++;
                    if (consecutiveDays == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{days}");
                        break;
                    }
                }
                else if (type == "save")
                {
                    money += num;
                    consecutiveDays = 0;
                    days++;
                    if (money >= cost)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                        break;
                    }
                }
            }
        }
    }
}
