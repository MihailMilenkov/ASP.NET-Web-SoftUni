namespace CSharpProgrammingBasics._10ForLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _000ForLoop
    {
        internal static void Start()
        {
            string input = Console.ReadLine();
            int sum = 0;
            while (input != "Stop")
            {
                int currentNum = int.Parse(input);
                sum += currentNum;
                input = Console.ReadLine();

            }
            Console.WriteLine(sum);
        }
    }
}
