namespace CSharpProgrammingBasics._04ConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _00ConditionalStatements3
    {
        internal static void Start()
        {
            string currentDay = "Monday";
            double salary = 0;

            if (currentDay == "Monday")
            {
                salary = double.Parse(Console.ReadLine());
            }
        }
    }
}
