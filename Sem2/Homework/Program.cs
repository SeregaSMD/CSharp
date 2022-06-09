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

//----------------------------------------------------------------------------------------------------
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//----------------------------------------------------------------------------------------------------
int num = new Random().Next(100, 1000);
Console.WriteLine($"A random number is: {num}");

int char1 = num / 100;
int char2 = (num / 10) % 10;
int char3 = num % 10;

Console.WriteLine($"The first numeral of the number is: {char1}");
Console.WriteLine($"The second numeral of the number is: {char2}");
Console.WriteLine($"The third numeral of the number is: {char3}");

Console.WriteLine($"The random number without 2nd numeral is: {char1}{char3}");

//------------------------------------------------------------------------------------------------------
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//------------------------------------------------------------------------------------------------------
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Your number is {number}.");

if (number < 100)
{
    Console.WriteLine($"Your number has less than 3 digits.");
}
else
{
    while (number >= 1000)
    {
        number = number / 10;
    }

    Console.WriteLine($"The third numeral of the number is {number % 10}.");
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