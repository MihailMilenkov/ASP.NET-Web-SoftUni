namespace CSharpProgrammingBasics._02SimpleOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _06CircleAreaAndPerimeter
    {
        internal static void Start()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = Math.PI * r * 2;

            Console.WriteLine("{0:f2}", area);
            Console.WriteLine("{0:f2}", perimeter);
        }
    }
}
