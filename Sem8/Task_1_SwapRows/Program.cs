// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void SwapRows(int [,] arr, int row1, int row2)
{
    int tmp;
    for (int j=0;j<arr.GetLength(1); j++)
    {
        tmp = arr [row2, j];
        arr [row2, j]=arr [row1, j];
        arr [row1, j]=tmp;
    }
}

string s;

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());

int [,] array = new int[rows, columns];
FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine($"Поменяли местами первую и последнюю строки:");
SwapRows(array,0,array.GetLength(0)-1);
PrintArray(array);