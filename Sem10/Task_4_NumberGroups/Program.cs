//Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты
//(все числа в группе друг на друга не делятся) найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.
using System;
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = i + 1;
    }
}

void PrintArray2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

bool CheckDivide(int[,] groups, int group, int value)
{
    for (int i = 0; i < groups.GetLength(1); i++)
    {
        if (groups[group, i] == 0) return true;
        if (value % groups[group, i] == 0) return false;
    }
    return true;
}

void AddNumber(int[,] groups, int group, int value)
{
    for (int i = 0; i < groups.GetLength(1); i++)
    {
        if (groups[group, i] == 0)
        {
            groups[group, i] = value;
            return;
        }
    }
}

(int, int) CountRowsColumns(int[,] arr)
{
    int maxRows = 0;
    int maxCols = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] != 0)
            {
                maxRows = Math.Max(maxRows, i);
                maxCols = Math.Max(maxCols, j);
            }
        }
    }
    return (maxRows, maxCols);
}

Console.Write("Введте число N: ");
int N = int.Parse(Console.ReadLine());
int[] numbers = new int[N];
int[,] groups = new int[N, N];

int[] tmpNumbers = new int[N];

FillArray(numbers);


int tmpNumIdx = 0;
for (int i = 0; i < groups.GetLength(0); i++)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        if (CheckDivide(groups, i, numbers[j]))
        {
            AddNumber(groups, i, numbers[j]);
        }
        else
        {
            tmpNumbers[tmpNumIdx] = numbers[j];
            tmpNumIdx++;
        }
    }
    tmpNumIdx = 0;
    Array.Copy(tmpNumbers, numbers, tmpNumbers.Length);
    Array.Clear(tmpNumbers);
}

int maxRows = 0;
int maxCols = 0;
(maxRows, maxCols) = CountRowsColumns(groups);
int[,] newGroups = new int[maxRows, maxCols];
newGroups=ArrayCopyNonZero (groups);
PrintArray2D(newGroups);

int[,] ArrayCopyNonZero(int[,] arr)
{
    int maxRows = 0;
    int maxCols = 0;
    (maxRows, maxCols) = CountRowsColumns(groups);
    
    int[,] newGroups = new int[maxRows+1, maxCols+1];
    for (int i = 0; i <= maxRows; i++)
    {
        for (int j = 0; j <= maxCols; j++)
        {
            newGroups[i,j]=arr[i,j];
        }
    }
    return newGroups;
}