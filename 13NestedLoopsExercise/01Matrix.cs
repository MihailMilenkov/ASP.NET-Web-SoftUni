namespace CSharpProgrammingBasics._13NestedLoopsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _01Matrix
    {
        internal static void Start()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int firstRowLeftNum = a; firstRowLeftNum <= b; firstRowLeftNum++)
            {
                for (int firstRowRightNum = a; firstRowRightNum <= b; firstRowRightNum++)
                {
                    for (int secondRowLeftNum = c; secondRowLeftNum <= d; secondRowLeftNum++)
                    {
                        for (int secondRowRightNum = c; secondRowRightNum <= d; secondRowRightNum++)
                        {
                            if (((firstRowLeftNum + secondRowRightNum == secondRowLeftNum + firstRowRightNum) &&
                                (firstRowLeftNum != firstRowRightNum) && (secondRowLeftNum != secondRowRightNum)))
                            {
                                Console.WriteLine($"{firstRowLeftNum}{firstRowRightNum}");
                                Console.WriteLine($"{secondRowLeftNum}{secondRowRightNum}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
