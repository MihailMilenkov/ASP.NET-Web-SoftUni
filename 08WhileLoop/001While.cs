namespace CSharpProgrammingBasics._08WhileLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _001While
    {
        internal static void Start()
        {
            int dishes = 20;

            while (dishes > 0)
            {
                Console.WriteLine("Wash!");
                dishes--;
            }
        }
    }
}
