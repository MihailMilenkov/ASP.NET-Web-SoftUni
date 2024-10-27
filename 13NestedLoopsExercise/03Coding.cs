namespace CSharpProgrammingBasics._13NestedLoopsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _03Coding
    {
        internal static void Start()
        {
            string inputNum = Console.ReadLine();

            for (int i = inputNum.Length - 1; i >= 0; i--)
            {
                char currentDigit = inputNum[i];
                int currentDigitToNumber = int.Parse(currentDigit.ToString());

                if (currentDigitToNumber == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }

                for (int n = 1; n <= currentDigitToNumber; n++)
                {
                    Console.Write((char)(currentDigitToNumber + 33));
                }

                Console.WriteLine();
            }
        }
    }
}
