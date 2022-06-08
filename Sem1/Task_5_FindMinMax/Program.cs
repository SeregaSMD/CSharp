// Написать программу, которая принимает на вход 2 числа и выдает какое больше, а какое меньше
Console.Write("Enter first number: ");
double number1 = double.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
double number2 = double.Parse(Console.ReadLine());

if (number1 < number2)
{
    Console.WriteLine($"Max number is {number2}, min number is {number1}");
}
else
{
    Console.WriteLine($"Max number is {number1}, min number is {number2}");
}