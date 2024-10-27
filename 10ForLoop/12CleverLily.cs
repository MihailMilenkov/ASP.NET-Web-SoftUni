namespace CSharpProgrammingBasics._10ForLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _12CleverLily
    {
        internal static void Start()
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int moneyGift = 10;

            int numberOfToys = 0;
            int totalMoneyFromBirthdays = 0;

            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 != 0)
                {
                    numberOfToys++;
                }
                else
                {
                    totalMoneyFromBirthdays += moneyGift;
                    totalMoneyFromBirthdays--;
                    moneyGift += 10;
                }
            }

            int moneyFromToys = numberOfToys * toyPrice;
            int savedMoney = moneyFromToys + totalMoneyFromBirthdays;

            if (savedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {savedMoney - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - savedMoney:f2}");
            }
        }
    }
}
