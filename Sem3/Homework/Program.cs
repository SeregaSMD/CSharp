//----------------------------------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Решение через числа
//----------------------------------------------------------------------------------------------------------
Console.Write("Enter an integer 5-digit number: ");
int num = int.Parse(Console.ReadLine());

int digitCount = (int)Math.Log10(num) + 1;
Console.WriteLine(digitCount);

if (num > 9999 && num < 100000)
{
    int c5 = num % 10;
    int c4 = (num /10) % 10;
    int c2 = (num /1000) % 10;
    int c1 = (num /10000) % 10;
    if ((c1 == c5) && (c2 == c4))
    {
        Console.WriteLine("Your number is a palindrome");
    }
    else
    {
        Console.WriteLine("Your number is not a palindrome");
    }
}
else
Console.Write("Your number is not a 5-digit integer. Please enter a correct number.");

//---------------------------------------------------------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом (сразу без привязки к 5-значности).
// Решение через числа
//---------------------------------------------------------------------------------------------------------------------------------
Console.Write("Enter an integer number: ");
int num = int.Parse(Console.ReadLine());
int tmpnum = num;
int digits = 1;
while (tmpnum / 10 != 0)
{
    tmpnum = tmpnum / 10;
    digits++;
}
tmpnum = num;
while (digits > 1)
{
    int fnum = tmpnum / ((int)Math.Pow(10, digits - 1));
    int lnum = tmpnum % 10;
    if (fnum != lnum)
    {
        Console.WriteLine($"Your number is {num}. It is not a Palidrome");
        break;
    }
    else
    {
        tmpnum = tmpnum / 10;
        digits = digits - 2;
        tmpnum = tmpnum % ((int)Math.Pow(10, digits));
    }
    if (digits <= 1)
    {
        Console.WriteLine($"Your number is {num}. It is a Palidrome");
    }
}

//-----------------------------------------------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//-----------------------------------------------------------------------------------------------------------------------
Console.Write("Enter first X coordinate: ");
double X1 = double.Parse(Console.ReadLine());
Console.Write("Enter first Y coordinate: ");
double Y1 = double.Parse(Console.ReadLine());
Console.Write("Enter first Z coordinate: ");
double Z1 = double.Parse(Console.ReadLine());
Console.Write("Enter second X coordinate: ");
double X2 = double.Parse(Console.ReadLine());
Console.Write("Enter second Y coordinate: ");
double Y2 = double.Parse(Console.ReadLine());
Console.Write("Enter first Z coordinate: ");
double Z2 = double.Parse(Console.ReadLine());
double dist = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)+Math.Pow(Z2 - Z1, 2));
Console.WriteLine($"Distance between your points is (with a precision up to 2 digits): {Math.Round(dist, 2)}");

//-------------------------------------------------------------------------------------------------
//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//-------------------------------------------------------------------------------------------------
Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int idx = 1;
Console.WriteLine($"Here we have the cubes for a number series ending with the number {num}: ");
if (num>0 && num<2147483647)
{
    while (idx < num)
{
    Console.Write($"{Math.Pow (idx, 3)}, ");
    idx++;
}
Console.Write($"{Math.Pow (idx, 3)}.");
}
else
{
    Console.WriteLine($"Your number is out of permissible range. Please enter an integer number between 1 and 2 147 483 647");
}