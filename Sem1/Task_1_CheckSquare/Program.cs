// Написать программу, которая принимает из консоли 2 числа и проверяет является ли первое число квадратом второго
Console.Write("Enter first number: ");
double Number1 = double.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
double Number2 = double.Parse(Console.ReadLine());

double Number2SQ = Math.Pow(Number2, 2);

Console.WriteLine($"Your first number is {Number1}");
Console.WriteLine($"Your second number is {Number2}");
if (Number1==Number2SQ)
{
    Console.WriteLine("The first number is a square for the second number");
}
else
{
    Console.WriteLine("The first number is not a square for the second number");
}