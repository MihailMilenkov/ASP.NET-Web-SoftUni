namespace CSharpProgrammingBasics._14ExamProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _07RoomPainting
    {
        internal static void Start()
        {
            double bucketsOfPaint = double.Parse(Console.ReadLine());
            double wallpaperRolls = double.Parse(Console.ReadLine());
            double pricePerPairOfGloves = double.Parse(Console.ReadLine());
            double pricePerBrush = double.Parse(Console.ReadLine());

            double piecesOfPairsOfGloves = Math.Ceiling(wallpaperRolls * .35);
            double piecesOfBrushes = Math.Floor(bucketsOfPaint * .48);

            double total = (pricePerBrush * piecesOfBrushes) + (pricePerPairOfGloves * piecesOfPairsOfGloves) + (bucketsOfPaint * 21.5) +
                (wallpaperRolls * 5.2);

            double deliveryCost = total / 15;

            Console.WriteLine($"This delivery will cost {deliveryCost:f2} lv.");
        }
    }
}
