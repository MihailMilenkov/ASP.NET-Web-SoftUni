namespace CSharpProgrammingBasics._02SimpleOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _08YardGreening
    {
        internal static void Start()
        {
            double area = double.Parse(Console.ReadLine());
            double price = area * 7.61;
            double discount = price * 0.18;
            double finalPrice = price - discount;

            Console.WriteLine("The final price is: {0:f2} lv.", finalPrice);
            Console.WriteLine("The discount is: {0:f2} lv.", discount);
        }
    }
}
