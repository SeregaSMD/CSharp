// Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
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

(int minIdx1, int minIdx2) FindMinIdx(int[,] arr)
{
    int minval = arr[0, 0];
    int minIdx1 = 0;
    int minIdx2 = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (minval > arr[i, j])
            {
                minval = arr[i, j];
                minIdx1 = i;
                minIdx2 = j;
            }
        }
    }
    return (minIdx1, minIdx2);
}

int[,] DelRowCol(int[,] arr, int idx1, int idx2)
{
    int[,] newArray = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i < idx1 && j < idx2) newArray[i, j] = arr[i, j];
            if (i < idx1 && j > idx2) newArray[i, j - 1] = arr[i, j];
            if (i > idx1 && j < idx2) newArray[i - 1, j] = arr[i, j];
            if (i > idx1 && j > idx2) newArray[i - 1, j - 1] = arr[i, j];
        }
    }
    return newArray;
}

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
(int minIdx1, int minIdx2) = FindMinIdx(array);
Console.WriteLine($"Индексы минимального элемента: {minIdx1} и {minIdx2}");
int[,] result = DelRowCol(array, minIdx1, minIdx2);
PrintArray(result);