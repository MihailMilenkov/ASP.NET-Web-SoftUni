namespace CSharpProgrammingBasics._02SimpleOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _09Aquarium
    {
        internal static void Start()
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double sandPercent = double.Parse(Console.ReadLine());

            int volume = length * width * height;
            double volumeInDecimeters = volume * 0.001;
            double attributesVolume = sandPercent * 0.01;
            double result = volumeInDecimeters * (1 - attributesVolume);

            Console.WriteLine("{0:f3}", result);
        }
    }
}
