//-----------------------------------------------------------------------------------------------------------------------
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//-----------------------------------------------------------------------------------------------------------------------

void FillArray(int[,] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);          
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

void ArraySortRow(int[,] arr, int row)
{
    int maxIdx = 0;    
    int maxVal = arr[row,maxIdx];
    for (int i = 0; i < arr.GetLength(1)-1; i++)
    {
        maxIdx=i;
        maxVal = arr[row, i];
        for (int j = i+1; j < arr.GetLength(1); j++)
        {
            if (arr[row, j] > maxVal)
            {
                maxIdx = j;
                maxVal = arr[row, j];
            }
        }
        if (maxIdx!=i)
        {
            Swap(arr, i, maxIdx, row);
        }
    }
}

void Swap(int[,] arr, int idx1, int idx2, int row)
{
    int tmp = arr[row, idx1];
    arr[row, idx1] = arr[row, idx2];
    arr[row, idx2] = tmp;
}

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);

Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine("Сортированный массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    ArraySortRow(array, i);
}
PrintArray(array);