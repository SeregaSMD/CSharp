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