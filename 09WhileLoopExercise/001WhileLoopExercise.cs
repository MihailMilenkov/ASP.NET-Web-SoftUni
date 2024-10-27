namespace CSharpProgrammingBasics._09WhileLoopExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _001WhileLoopExercise
    {
        internal static void Start()
        {
            string name = Console.ReadLine();

            while (name != "END")
            {
                if (name == "Peter")
                {
                    Console.WriteLine(name);
                    break;
                }

                name = Console.ReadLine();
            }

            Console.WriteLine("dsadasdasdasdasd");
        }
    }
}
