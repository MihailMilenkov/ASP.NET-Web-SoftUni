namespace CSharpProgrammingBasics._07NestedConditionalStatementsEcercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _07OperationsBetweenNumbers
    {
        internal static void Start()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double result = 0;
            string type = "";

            switch (op)
            {
                case "*":
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        type = "even";
                    }
                    else
                    {
                        type = "odd";
                    }
                    break;
                case "-":
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        type = "even";
                    }
                    else
                    {
                        type = "odd";
                    }
                    break;
                case "+":
                    result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        type = "even";
                    }
                    else
                    {
                        type = "odd";
                    }
                    break;
                case "/":
                    result = n1 / n2;
                    break;
                case "%":
                    result = n1 % n2;
                    break;
            }

            if ((op == "/" || op == "%") && n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if ((op == "+") || (op == "-") || (op == "*"))
            {
                Console.WriteLine($"{n1} {op} {n2} = {result} - {type}");
            }
            else if (op == "%")
            {
                Console.WriteLine($"{n1} % {n2} = {result}");
            }
            else if (op == "/")
            {
                Console.WriteLine($"{n1} / {n2} = {result:f2}");
            }
        }
    }
}
