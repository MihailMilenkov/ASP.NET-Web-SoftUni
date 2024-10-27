namespace CSharpProgrammingBasics._13NestedLoopsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _07PasswordGenerator
    {
        internal static void Start()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int one = 1; one < n; one++)
            {
                for (int two = 1; two < n; two++)
                {
                    for (int three = 'a'; three < 'a' + l; three++)
                    {
                        for (int four = 'a'; four < 'a' + l; four++)
                        {
                            int startFiveSymbol = Math.Max(one, two) + 1;
                            for (int five = startFiveSymbol; five <= n; five++)
                            {
                                Console.Write($"{one}{two}{(char)three}{(char)four}{five} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
