namespace CSharpProgrammingBasics._09WhileLoopExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _04Walking
    {
        internal static void Start()
        {
            string input = Console.ReadLine();
            int totalSteps = 0;

            while (input != "Going home")
            {
                int steps = int.Parse(input);
                totalSteps += steps;

                if (totalSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "Going home")
            {
                int stepsToHome = int.Parse(Console.ReadLine());
                totalSteps += stepsToHome;

                if (10000 <= totalSteps)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
                else
                {
                    Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
                }
            }
        }
    }
}
