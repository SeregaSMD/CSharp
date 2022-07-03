Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
int divider1 = 7;
int divider2 = 23;

if (number%divider1 == 0 && number%divider2 == 0)
{
    Console.WriteLine($"Your number is even to {divider1} and {divider2}.");
}
else
{
    Console.WriteLine($"Your number isn't even to {divider1} and {divider2}.");
}