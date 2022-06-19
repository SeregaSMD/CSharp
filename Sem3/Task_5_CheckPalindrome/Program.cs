// Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом (сразу без привязки к 5-значности).
// Решение через числа
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