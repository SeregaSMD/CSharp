// Написать программу, которая принимает на вход 3 числа и выдает максимальное
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