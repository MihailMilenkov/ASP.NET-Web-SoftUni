namespace CSharpProgrammingBasics._03SimpleOperationsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _07DanceHall
    {
        internal static void Start()
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double area = L * W;
            area = area - (A * A) - area / 10;
            area = area * 10000;

            double numberOfDancers = area / 7040;

            Console.WriteLine(Math.Floor(numberOfDancers));
        }
    }
}
