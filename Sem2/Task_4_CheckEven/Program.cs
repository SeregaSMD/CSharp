Console.Write("Enter first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int number2 = int.Parse(Console.ReadLine());

if (number2%number1 == 0)
{
    Console.WriteLine("The second number is even to the first.");
}
else
{
    Console.WriteLine($"The second number isn't even to the first. The residual is {number2%number1}.");
}