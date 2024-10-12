namespace CSharpProgrammingBasics._03SimpleOperationsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _05RectangleArea
    {
        internal static void Start()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double length = Math.Abs(x1 - x2);
            double width = Math.Abs(y1 - y2);

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");

            // CTRL K D - format code
            // CTRL L - delete current line 
        }
    }
}
