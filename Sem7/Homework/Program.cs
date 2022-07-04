//-------------------------------------------------------------------------------------
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//-------------------------------------------------------------------------------------

void PrintArray(double[,] arr)
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

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(new Random().Next(0, 10) + new Random().NextDouble(), 2);
        }
    }
}

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int col = int.Parse(Console.ReadLine());
double[,] mass = new double[row, col];
FillArray(mass);
PrintArray(mass);

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
//  Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
void PrintArray(double[,] arr)
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

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(new Random().Next(0, 10) + new Random().NextDouble(), 2);
        }
    }
}

double FindElem(double[,] arr, int pos)
{
    double elem=-100500;
    if (arr.Length>=pos)
    {
        int row = (pos-1)/arr.GetLength(1);
        int col = (pos-1)%arr.GetLength(1);
        return elem = arr[row, col];
    }
    else
    {
        return elem;
    }
}

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int col = int.Parse(Console.ReadLine());
double[,] mass = new double[row, col];
FillArray(mass);
PrintArray(mass);

Console.Write("Введите позицию искомого элемента: ");
int position = int.Parse(Console.ReadLine());
double elem = FindElem(mass, position);
if (elem != -100500)
{
    Console.Write($"Выбранный элемент массива равен: {elem}.");
}
else
{
    Console.Write($"Элемента с позицией {position} не существует.");
}

//----------------------------------------------------------------------------------------------------
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//----------------------------------------------------------------------------------------------------

void PrintArray(int[,] arr)
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

void PrintArrayDouble(double[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write(arr[i] + "   ");
    }
    Console.WriteLine();
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

double FindColumnMean(int[,] arr, int col)
{
    double columnSum=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        columnSum += arr[i, col];
    }
    return columnSum / arr.GetLength(0);
}

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int col = int.Parse(Console.ReadLine());
int[,] mass = new int[row, col];

FillArray(mass);
Console.WriteLine("Сгенерирован массив случайных целых чисел:");
PrintArray(mass);

double[] columnMean = new double[mass.GetLength(1)];
for (int j = 0; j < columnMean.Length; j++)
{
    columnMean[j] = Math.Round(FindColumnMean(mass, j), 2);
}
Console.WriteLine("Среднее арифмитическое по столбцам:");
PrintArrayDouble(columnMean);