// Написать программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.
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