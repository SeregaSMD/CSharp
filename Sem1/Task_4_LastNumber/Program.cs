// Написать программу, которая принимает на вход трехзначное число и на выходе показывает последнюю его цифру
Console.Write("Enter a 3-digit integer number: ");
int number = int.Parse(Console.ReadLine());

int last_numeral = number % 10;
Console.Write($"The last numeral of your number is {last_numeral}.");