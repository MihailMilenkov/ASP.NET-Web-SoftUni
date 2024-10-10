// See https://aka.ms/new-console-template for more information
//

// 1. Age group
//int age = int.Parse(Console.ReadLine());

//if (age >= 0 && age <= 2)
//{
//    Console.WriteLine("baby");
//}
//else if (age <= 13)
//{
//    Console.WriteLine("child");
//}
//else if (age <= 19)
//{
//    Console.WriteLine("teenager");
//}
//else if (age <= 65)
//{
//    Console.WriteLine("adult");
//}
//else if (age >= 66)
//{
//    Console.WriteLine("elder");
//}

// 2. Division
int dividend = int.Parse(Console.ReadLine());

if (dividend % 10 == 0)
{
    Console.WriteLine("The number is divisible by 10");
}
else if (dividend % 7 == 0)
{
    Console.WriteLine("The number is divisible by 7");
}
else if (dividend % 6 == 0)
{
    Console.WriteLine("The number is divisible by 6");
}
else if (dividend % 3 == 0)
{
    Console.WriteLine("The number is divisible by 3");
}
else if (dividend % 2 == 0)
{
    Console.WriteLine("The number is divisible by 2");
}
else
{
    Console.WriteLine("Not divisible");
}