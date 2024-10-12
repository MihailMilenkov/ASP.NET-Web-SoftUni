namespace CSharpProgrammingBasics._02SimpleOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _07PetShop
    {
        internal static void Start()
        {
            int dogCount = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());

            double totalSum = dogCount * 2.5 + otherAnimals * 4;
            Console.WriteLine("{0:f2} lv.", totalSum);
        }
    }
}
