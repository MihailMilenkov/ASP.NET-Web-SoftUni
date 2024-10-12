namespace CSharpProgrammingBasics._02SimpleOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _03SquareArea
    {
        internal static void Start()
        {
            int side = int.Parse(Console.ReadLine());

            int area = side * side;
            Console.WriteLine(area);
        }
    }
}
