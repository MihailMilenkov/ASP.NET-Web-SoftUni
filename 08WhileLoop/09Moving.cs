namespace CSharpProgrammingBasics._08WhileLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _09Moving
    {
        internal static void Start()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeSpace = width * length * height;
            string command = Console.ReadLine();

            while (command != "Done")
            {
                int boxes = int.Parse(command);

                if (freeSpace >= boxes)
                {
                    freeSpace -= boxes;
                }
                else
                {
                    Console.WriteLine($"No more free space! You need {boxes - freeSpace} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }

            if (command == "Done")
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
