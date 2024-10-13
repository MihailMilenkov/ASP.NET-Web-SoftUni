namespace CSharpProgrammingBasics._05ConditionalStatementsExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _07SwimmingRecord
    {
        internal static void Start()
        {
            double wordlRecord = double.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            double timeFor1m = double.Parse(Console.ReadLine());

            double totalTime = distanceInM * timeFor1m;
            double delay = Math.Floor(distanceInM / 15) * 12.5;

            double finalTime = totalTime + delay;

            if (finalTime > wordlRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {finalTime - wordlRecord} seconds slower.");
            }
        }
    }
}
