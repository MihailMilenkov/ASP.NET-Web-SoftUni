namespace CSharpProgrammingBasics._05ConditionalStatementsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _08Scholarship
    {
        internal static void Start()
        {
            double income = double.Parse(Console.ReadLine());
            double averageScore = double.Parse(Console.ReadLine());
            double minPay = double.Parse(Console.ReadLine());

            double socialPay = Math.Floor(minPay * 0.35);
            double excellentPay = Math.Floor(averageScore * 25);


            if (income < minPay && averageScore >= 5.5 && socialPay > excellentPay)
            {
                Console.WriteLine($"You get a Social scholarship {socialPay} BGN");
            }

            else if (income < minPay && averageScore >= 5.5 && socialPay < excellentPay)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentPay} BGN");
            }

            else if (income < minPay && averageScore >= 5.5 && socialPay == excellentPay)
            {
                Console.WriteLine($"You get a Social scholarship {socialPay} BGN");
            }


            else if (income < minPay && averageScore > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialPay} BGN");
            }


            else if (averageScore >= 5.5)
            {

                Console.WriteLine($"You get a scholarship for excellent results {excellentPay} BGN");
            }


            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
