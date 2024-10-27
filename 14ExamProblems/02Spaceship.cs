namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _02Spaceship
    {
        internal static void Start()
        {
            double shipWidth = double.Parse(Console.ReadLine());
            double shipLength = double.Parse(Console.ReadLine());
            double shipHeight = double.Parse(Console.ReadLine());
            double averageManHeight = double.Parse(Console.ReadLine());

            double volume = shipHeight * shipLength * shipWidth;
            double roomVolume = (averageManHeight + .4) * 2 * 2;

            if (volume / roomVolume < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (volume / roomVolume < 11)
            {
                Console.WriteLine($"The spacecraft holds {Math.Floor(volume / roomVolume)} astronauts.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
