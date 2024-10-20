namespace CSharpProgrammingBasics._08WhileLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _000While
    {
        internal static void Start()
        {
            int a = 5;

            //Console.WriteLine(a++); post
            //Console.WriteLine(++a); pre

            Console.WriteLine(a++);
            Console.WriteLine(++a);

            Console.WriteLine(a--);
            Console.WriteLine(--a);
        }
    }
}
