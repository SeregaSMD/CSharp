//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Console.Write("Введите целочисленное значение: ");
int number = int.Parse(Console.ReadLine());

int SumNumeral(int num)
{
    if (num == 0) return 0;
    return SumNumeral(num / 10) + num % 10;
}

Console.WriteLine(SumNumeral(number));