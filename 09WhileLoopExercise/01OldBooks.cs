namespace CSharpProgrammingBasics._09WhileLoopExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _01OldBooks
    {
        internal static void Start()
        {
            string favBook = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int checkedBooks = 0;
            string currentBook = Console.ReadLine();

            while (currentBook != favBook)
            {
                checkedBooks++;
                if (checkedBooks == capacity)
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {checkedBooks} books.");
                    break;
                }
                currentBook = Console.ReadLine();

            }

            if (capacity > checkedBooks)
            {
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
            }
        }
    }
}
