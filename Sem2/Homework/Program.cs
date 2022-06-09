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

//---------------------------------------------------------------------------------------------------------------------------
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//---------------------------------------------------------------------------------------------------------------------------
Console.Write($"Enter a weekdaynumber: ");
int WeekdayNumber = int.Parse(Console.ReadLine());
Console.WriteLine($"Your weekday number is {WeekdayNumber}.");
if (WeekdayNumber<=7 && WeekdayNumber>=1)
{
    if (WeekdayNumber<=5)
    {
        Console.WriteLine($"Your weekday is not a weekend.");
    }
    else
    {
        Console.WriteLine($"Your weekday is a weekend.");
    }
}
else
{
    Console.WriteLine("Your number is not a weekday.");
}