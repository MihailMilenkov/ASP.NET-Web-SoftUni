namespace CSharpProgrammingBasics._12NestedLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _06NameWars
    {
        internal static void Start()
        {
            int winPoints = 0;
            string winName = "";
            int currentPoints = 0;

            string currentName = Console.ReadLine();

            while (currentName != "STOP")
            {
                for (int i = 0; i < currentName.Length; i++)
                {
                    currentPoints += (char)currentName[i];
                    if (currentPoints > winPoints)
                    {
                        winPoints = currentPoints;
                        winName = currentName;
                    }

                }
                currentPoints = 0;
                currentName = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winName} - {winPoints}!");
        }
    }
}
