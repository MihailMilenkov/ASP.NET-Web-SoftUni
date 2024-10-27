namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _05Bus
    {
        internal static void Start()
        {
            int totalMen = int.Parse(Console.ReadLine());
            int stopsNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stopsNum; i++)
            {
                int menOut = int.Parse(Console.ReadLine());
                int menIn = int.Parse(Console.ReadLine());

                totalMen -= menOut;
                totalMen += menIn;

                if (i % 2 == 0)
                {
                    totalMen -= 2;
                }
                else
                {
                    totalMen += 2;
                }

            }
            Console.WriteLine($"The final number of passengers is : {totalMen}");
        }
    }
}
