//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите целочисленное значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите целочисленное значение N: ");
int N = int.Parse(Console.ReadLine());

(int NumberStart, int NumberFinish) MinMax(int NumberStart, int NumberFinish)
{
    int tmp;
    if (NumberStart > NumberFinish)
    {
        tmp = NumberStart;
        NumberStart = NumberFinish;
        NumberFinish = tmp;
    }
    return (NumberStart, NumberFinish);
}

void NumberSeries(int NumberStart, int NumberFinish)
{
    if (NumberStart > NumberFinish)
    {
        return;
    }
    Console.WriteLine(NumberStart);
    NumberSeries(NumberStart + 1, NumberFinish);
}

(N, M) = MinMax(N, M);
NumberSeries(N, M);