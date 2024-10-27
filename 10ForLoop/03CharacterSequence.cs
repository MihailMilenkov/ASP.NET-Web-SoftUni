namespace CSharpProgrammingBasics._10ForLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _03CharacterSequence
    {
        internal static void Start()
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                Console.WriteLine(letter);
            }
        }
    }
}
