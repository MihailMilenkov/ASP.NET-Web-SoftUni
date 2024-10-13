namespace CSharpProgrammingBasics._05ConditionalStatementsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _05Time
    {
        internal static void Start()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = hours * 60 + minutes + 15;
            int outHours = totalMinutes / 60;
            int outMinutes = totalMinutes % 60;

            if (hours == 23 && minutes > 44)
            {
                outHours = 0;
            }
            if (outMinutes < 10)
            {
                Console.WriteLine($"{outHours}:0{outMinutes}");
            }
            else
            {
                Console.WriteLine($"{outHours}:{outMinutes}");
            }

        }
    }
}
