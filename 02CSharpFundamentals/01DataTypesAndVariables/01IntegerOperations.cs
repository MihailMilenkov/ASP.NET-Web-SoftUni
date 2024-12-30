namespace _02CSharpFundamentals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _01IntegerOperations
    {
        internal static void Start()
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());

            Console.WriteLine((one + two) / three * four);
        }
    }
}
