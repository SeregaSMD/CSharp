Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number%7 == 0 && number%23 == 0)
{
    Console.WriteLine("Your number is even to 7 и 23.");
}
else
{
    Console.WriteLine("Your number isn't even to 7 и 23.");
}