// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В том числе для прямоугольной матрицы.
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

int [,] SwapRowsColumns(int[,] arr)
{        
    int [,] result =new int [arr.GetLength(1), arr.GetLength(0)];
    for (int i=0; i<result.GetLength(0); i++)
    {
        for (int j=0;j<result.GetLength(1); j++)
        {
            result [i,j]=arr[j,i];
        }
    }
    return result;
}

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine($"Поменяли местами строки и столбцы:");
PrintArray(SwapRowsColumns(array));