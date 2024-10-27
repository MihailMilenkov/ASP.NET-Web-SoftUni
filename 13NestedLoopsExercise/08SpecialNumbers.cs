namespace CSharpProgrammingBasics._13NestedLoopsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _08SpecialNumbers
    {
        internal static void Start()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int firstNum = 0;
                int secondNum = 0;
                int thirdNum = 0;
                int fourthNum = 0;

                for (int j = 0; j < 4; j++)
                {
                    string currentNumAsString = i.ToString();
                    char currentDigitAsChar = currentNumAsString[j];
                    int currentDigit = int.Parse(currentDigitAsChar.ToString());

                    if (j == 0)
                    {
                        firstNum = currentDigit;
                    }
                    if (j == 1)
                    {
                        secondNum = currentDigit;
                    }
                    if (j == 2)
                    {
                        thirdNum = currentDigit;
                    }
                    if (j == 3)
                    {
                        fourthNum = currentDigit;
                    }
                }
                if ((firstNum != 0) && (secondNum != 0) && (thirdNum != 0) && (fourthNum != 0))
                {
                    if ((n % firstNum == 0) && (n % secondNum == 0) && (n % thirdNum == 0) && (n % fourthNum == 0))
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
    }
}
