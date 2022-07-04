//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите целочисленное значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите целочисленное значение N: ");
int N = int.Parse(Console.ReadLine());

void NumberSeries(int NumberStart, int NumberFinish)
{
    if (NumberStart - NumberFinish==0)
    {
        return 0;
    }
    Console.WriteLine(NumberStart);
    NumberSeries(Math.Abs(NumberStart - NumberFinish));

}

(N, M) = MinMax(N, M);
NumberSeries(N, M);