namespace CSharpProgrammingBasics._07NestedConditionalStatementsEcercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _01PointOnRectangleBorder
    {
        internal static void Start()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool condition1 = x == x1 && (y >= y1 && y <= y2);
            bool condition2 = y == y1 && (x >= x1 && x <= x2);
            bool condition3 = y == y2 && (x >= x1 && x <= x2);
            bool condition4 = x == x2 && (y >= y1 && y <= y2);

            if (condition1 || condition2 || condition3 || condition4)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
