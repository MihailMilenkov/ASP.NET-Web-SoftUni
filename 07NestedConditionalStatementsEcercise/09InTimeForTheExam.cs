namespace CSharpProgrammingBasics._07NestedConditionalStatementsEcercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _09InTimeForTheExam
    {
        internal static void Start()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examT = examHour * 60 + examMinutes;
            int arrivalT = arrivalHour * 60 + arrivalMinutes;

            if (examT >= arrivalT && arrivalT >= (examT - 30))
            {
                Console.WriteLine("On time");
            }
            else if (examT < arrivalT)
            {
                Console.WriteLine("Late");
            }
            else if (examT > (arrivalT + 30))
            {
                Console.WriteLine("Early");
            }


            if (arrivalT < examT && arrivalT > (examT - 60))
            {
                Console.WriteLine($"{(examT - arrivalT)} minutes before the start");
            }

            else if (arrivalT <= (examT - 60))
            {
                if (((examT - arrivalT) % 60) < 10)
                {
                    Console.WriteLine($"{(Math.Abs(arrivalT - examT) / 60)}:0{Math.Abs(arrivalT - examT) % 60} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{(Math.Abs(arrivalT - examT) / 60)}:{Math.Abs(arrivalT - examT) % 60} hours before the start");
                }
            }

            else if (arrivalT > examT && arrivalT < (examT + 60))
            {
                Console.WriteLine($"{(arrivalT - examT) % 60} minutes after the start");
            }

            else if (arrivalT >= (examT + 60))
            {
                if (((arrivalT - examT) % 60) < 10)
                {
                    Console.WriteLine($"{(Math.Abs(arrivalT - examT) / 60)}:0{Math.Abs(arrivalT - examT) % 60} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{(Math.Abs(arrivalT - examT) / 60)}:{Math.Abs(arrivalT - examT) % 60} hours after the start");
                }
            }
        }
    }
}
