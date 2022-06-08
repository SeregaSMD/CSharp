// Написать программу, которая принимает на вход 1 число и выдает является ли оно четным
Console.Write("Enter integer number: ");
int number = int.Parse(Console.ReadLine());
Console.Write($"Your number is {number}. ");

if (number % 2 == 0)
{
    Console.Write("It is even.");
}
else 
{
    Console.Write("It isn't even.");
}