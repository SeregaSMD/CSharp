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