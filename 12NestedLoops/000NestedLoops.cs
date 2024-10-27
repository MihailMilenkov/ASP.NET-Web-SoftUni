namespace CSharpProgrammingBasics._12NestedLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _000NestedLoops
    {
        internal static void Start()
        {
            //break  
            //continue p
            //return 
            for (int h = 0; h < 24; h++)
            {
                for (int m = 0; m < 60; m++)
                {
                    if (h < 10)
                    {
                        if (m < 10)
                        {
                            Console.WriteLine($"0{h}:0{m}");
                        }
                        else
                        {
                            Console.WriteLine($"0{h}:{m}");
                        }
                        continue;

                    }
                    else if (m < 10)
                    {
                        Console.WriteLine($"{h}:0{m}");
                        continue;
                    }

                    Console.WriteLine($"{h}:{m}");
                }
            }
        }
    }
}
