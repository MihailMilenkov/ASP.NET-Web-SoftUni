namespace CSharpProgrammingBasics._13NestedLoopsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _05EqualSumsLeftRightPosition
    {
        internal static void Start()
        {
            int minNum = int.Parse(Console.ReadLine());
            int maxNum = int.Parse(Console.ReadLine());

            for (int i = minNum; i <= maxNum; i++)
            {
                int currentLeftSum = 0;
                int currentMiddle = 0;
                int currentRightSum = 0;
                string currentNum = i.ToString();

                for (int j = 0; j <= currentNum.Length; j++)
                {
                    char currentDigitAsChar = currentNum[i];
                    int currentDigit = int.Parse(currentDigitAsChar.ToString());
                    if (j <= 1)
                    {
                        currentLeftSum += currentDigit;
                    }
                    else if (j == 2)
                    {
                        currentMiddle = currentDigit;
                    }
                    else if (j <= 4)
                    {
                        currentRightSum += currentDigit;
                    }
                }

                if (currentLeftSum == currentRightSum)
                {
                    Console.Write($"{i} ");
                }
                else if (currentLeftSum + currentMiddle == currentRightSum || currentLeftSum == currentMiddle + currentRightSum)
                {
                    Console.Write($"{i} ");
                }
            }

        }
    }
}
