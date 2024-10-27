namespace CSharpProgrammingBasics._13NestedLoopsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _02NumberPyramid
    {
        internal static void Start()
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 1;
            bool isBigger = false;

            for (int row = 1; row <= num; row++)
            {
                for (int j = 1; j <= row; j++)
                {
                    Console.Write(counter++ + " ");

                    if (counter == num + 1)
                    {
                        isBigger = true;
                        break;
                    }
                }

                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
