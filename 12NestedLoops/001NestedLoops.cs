namespace CSharpProgrammingBasics._12NestedLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _001NestedLoops
    {
        internal static void Start()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool flag = false;

            for (int i = start; i < end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    int res = i + j;
                    combinations++;

                    if (res == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {res})");
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine($"{combinations} combinations - neither");
            }
        }
    }
}
