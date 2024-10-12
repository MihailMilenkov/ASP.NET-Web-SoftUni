namespace CSharpProgrammingBasics._04ConditionalStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _09ToyShop
    {
        internal static void Start()
        {
            double puzzle = 2.6;
            double doll = 3;
            double bear = 4.1;
            double minion = 8.2;
            double truck = 2;

            double price = double.Parse(Console.ReadLine());
            double puzzlePcs = double.Parse(Console.ReadLine());
            double dollPcs = double.Parse(Console.ReadLine());
            double bearPcs = double.Parse(Console.ReadLine());
            double minionPcs = double.Parse(Console.ReadLine());
            double truckPcs = double.Parse(Console.ReadLine());

            double money = (puzzle * puzzlePcs) + (doll * dollPcs) + (bear * bearPcs) + (minion * minionPcs) + (truck * truckPcs);
            if (puzzlePcs + dollPcs + bearPcs + minionPcs + truckPcs >= 50)
            {
                money *= 0.75;
            }

            money = money *= 0.9;

            if (money >= price)
            {
                double moneyLeft = money - price;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeeded = price - money;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
        }
    }
}
