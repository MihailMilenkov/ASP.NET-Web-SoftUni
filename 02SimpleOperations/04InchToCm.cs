namespace CSharpProgrammingBasics._02SimpleOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _04InchToCm
    {
        internal static void Start()
        {
            double inches = double.Parse(Console.ReadLine());

            double centemeters = inches * 2.54;

            Console.WriteLine($"{centemeters:f2}");
        }
    }
}
