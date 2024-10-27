namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _06MultiplyTable
    {
        internal static void Start()
        {
            string input = Console.ReadLine();
            int inputAsNum = int.Parse(input);
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char currentDigit = input[i];
                int currentDigitToNumber = int.Parse(currentDigit.ToString());
                if (i == 2)
                {
                    num1 = currentDigitToNumber;
                }
                else if (i == 1)
                {
                    num2 = currentDigitToNumber;
                }
                else if (i == 0)
                {
                    num3 = currentDigitToNumber;
                }
            }

            for (int i = 1; i <= num1; i++)
            {
                for (int j = 1; j <= num2; j++)
                {
                    for (int l = 1; l <= num3; l++)
                    {
                        Console.WriteLine($"{i} * {j} * {l} = {i * j * l};");
                    }
                }
            }
        }
    }
}
