//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите целочисленное значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите целочисленное значение N: ");
int N = int.Parse(Console.ReadLine());

void NumberSeries(int numberStart, int numberFinish, int direction)
{
    if (numberStart == numberFinish+direction)
    {
        return;
    }
    Console.WriteLine(numberStart);    
    NumberSeries(numberStart+direction, numberFinish, direction);
    return;
}

int growDirection;
if (M<N)
{
    growDirection = 1;
}
else
{
    growDirection = -1;
}
NumberSeries(M, N, growDirection);