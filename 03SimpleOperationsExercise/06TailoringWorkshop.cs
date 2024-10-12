namespace CSharpProgrammingBasics._03SimpleOperationsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _06TailoringWorkshop
    {
        internal static void Start()
        {
            int broitables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            int kvmpokrivka = 7;
            int kvmkare = 9;

            double areapokrivki = (length + 2 * 0.30) * (width + 2 * 0.30);
            double areakareta = length / 2 * length / 2;

            double pokrivkafinal = kvmpokrivka * broitables * areapokrivki;
            double karefinal = kvmkare * broitables * areakareta;



            double usd = karefinal + pokrivkafinal;
            double bgn = usd * 1.85;

            Console.WriteLine($"{usd:f2} USD");
            Console.WriteLine($"{bgn:f2} BGN");

        }
    }
}
