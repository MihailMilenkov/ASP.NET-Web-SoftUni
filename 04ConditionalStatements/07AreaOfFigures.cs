namespace CSharpProgrammingBasics._04ConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _07AreaOfFigures
    {
        internal static void Start()
        {
            string inputOne = Console.ReadLine();
            double squareArea = 0;
            double rectangleArea = 0;
            double triangleArea = 0;
            double circleArea = 0;

            //string squareArea = square;

            if (inputOne == "square")
            {
                double a = double.Parse(Console.ReadLine());
                squareArea = a * a;
                Console.WriteLine($"{squareArea:f3}");
            }
            else if (inputOne == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                rectangleArea = a * b;
                Console.WriteLine($"{rectangleArea:f3}");
            }
            else if (inputOne == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                circleArea = (a * a) * Math.PI;
                Console.WriteLine($"{circleArea:f3}");
            }
            else if (inputOne == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double aH = double.Parse(Console.ReadLine());
                triangleArea = (aH * a) / 2;
                Console.WriteLine($"{triangleArea:f3}");
            }
        }
    }
}
