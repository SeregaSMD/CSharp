// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите целочисленное значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите целочисленное значение N: ");
int N = int.Parse(Console.ReadLine());

(int numberStart, int numberFinish) MinMax(int numberStart, int numberFinish)
{
    int tmp;
    if (numberStart > numberFinish)
    {
        tmp = numberStart;
        numberStart = numberFinish;
        numberFinish = tmp;
    }
    return (numberStart, numberFinish);
}

int SumAB(int numberStart, int numberFinish)
{
    int sumAB=0;
    if (numberStart > numberFinish)
    {
        return 0;
    }    
    return sumAB=SumAB(numberStart+1, numberFinish)+numberStart;
}

(N, M) = MinMax(N, M);
Console.Write($"Сумма ряда от {N} до {M} равна {SumAB(N, M)}");