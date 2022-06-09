Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
int divider1 = 7;
int divider2 = 23;


if (number%7 == 0 && number%23 == 0)
{
    Console.WriteLine("Your number is even to 7 и 23.");
}
else
{
    Console.WriteLine("Your number isn't even to 7 и 23.");
}