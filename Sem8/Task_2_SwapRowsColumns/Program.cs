// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

bool SwapRowsColumns(int[,] arr)
{
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        Console.Write("Матрица не квадратная.");
        return false;
    }
    int tmp;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i; j < arr.GetLength(1); j++)
        {
            tmp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = tmp;
        }
    }
    return true;
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
if (SwapRowsColumns(array))
{
PrintArray(array);
}
