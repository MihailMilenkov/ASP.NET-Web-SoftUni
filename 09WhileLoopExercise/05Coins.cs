namespace CSharpProgrammingBasics._09WhileLoopExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _05Coins
    {
        internal static void Start()
        {
            double input = double.Parse(Console.ReadLine());
            double stotinki = input * 100;
            int coinCount = 0;

            if (stotinki > 0)
            {
                while (stotinki >= 200)
                {
                    coinCount++;
                    stotinki -= 200;
                }
                while (stotinki >= 100)
                {
                    coinCount++;
                    stotinki -= 100;
                }
                while (stotinki >= 50)
                {
                    coinCount++;
                    stotinki -= 50;
                }
                while (stotinki >= 20)
                {
                    coinCount++;
                    stotinki -= 20;
                }
                while (stotinki >= 10)
                {
                    coinCount++;
                    stotinki -= 10;
                }
                while (stotinki >= 5)
                {
                    coinCount++;
                    stotinki -= 5;
                }
                while (stotinki >= 2)
                {
                    coinCount++;
                    stotinki -= 2;
                }
                while (stotinki >= 1)
                {
                    coinCount++;
                    stotinki -= 1;
                }
            }
            Console.WriteLine(coinCount);
        }
    }
}
