﻿//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
void NumberSeries(int Number)
{
    if (Number == 0)
    {
        return;
    }
    NumberSeries(Number - 1);
    Console.WriteLine(Number);
}

Console.Write("Введите целочисленное значение N: ");
int N = int.Parse(Console.ReadLine());
NumberSeries(N);