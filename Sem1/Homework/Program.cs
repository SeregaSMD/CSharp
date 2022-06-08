//------------------------------------------------------------------------------------------------------
// Задача 2. Написать программу, которая принимает на вход 2 числа и выдает какое больше, а какое меньше
//------------------------------------------------------------------------------------------------------
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
//--------------------------------------------------------------------------------------
// Задача 4. Написать программу, которая принимает на вход 3 числа и выдает максимальное
//--------------------------------------------------------------------------------------
Console.Write("Enter first number: ");
double number1 = double.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
double number2 = double.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
double number3 = double.Parse(Console.ReadLine());

double maxnumber = number1;

if (number2 < number3)
{
    if (maxnumber<number3)
    {
        maxnumber=number3;
    }    
}
else 
{
    if (maxnumber<number2)
    {
        maxnumber=number2;
    }    
}
Console.WriteLine($"Max number is {maxnumber}.");
//------------------------------------------------------------------------------------------------
// Задача 6. Написать программу, которая принимает на вход 1 число и выдает является ли оно четным
//------------------------------------------------------------------------------------------------
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
//--------------------------------------------------------------------------------------------------------------------
// Задача 8. Написать программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.
//--------------------------------------------------------------------------------------------------------------------
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number<2) 
{
    Console.Write($"Your number is {number}. There are no natural even numbers between 1 and {number}.");
}
else
{
    int Counter = 2;
    Console.Write($"Your number is {number}. All even numbers from 1 to {number} are:");

    while (Counter <= number)
    {
        Console.Write(" " + Counter);
        Counter+=2;
    }
    Console.Write(".");
}