//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

int digits = 1;
int tmp = A;
int sum = 0;
while (A > 0)
{
    sum += A % 10;
    A = A / 10;
}
Console.Write($"Сумма цифр в числе {tmp} равна {sum}");