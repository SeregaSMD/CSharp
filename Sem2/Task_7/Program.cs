//----------------------------------------------------------------------------------------------------------------
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//----------------------------------------------------------------------------------------------------------------
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Your number is {number}.");

if (number < 100 || number > 999)
{
    Console.WriteLine($"Your number is not a 3 digit number.");
}
else
{
    Console.WriteLine($"The second numeral of the number is {(number / 10) % 10}.");
} 