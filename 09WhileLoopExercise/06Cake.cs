namespace CSharpProgrammingBasics._09WhileLoopExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _06Cake
    {
        internal static void Start()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int c = a * b;
            int totalTaken = 0;

            while (input != "STOP")
            {
                int taken = int.Parse(input);
                totalTaken += taken;

                if (totalTaken > c)
                {
                    Console.WriteLine($"No more cake left! You need {totalTaken - c} pieces more.");
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "STOP")
            {
                Console.WriteLine($"{c - totalTaken} pieces are left.");
            }
        }
    }
}
