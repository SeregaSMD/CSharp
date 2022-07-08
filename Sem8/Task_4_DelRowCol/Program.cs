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

int FindMin(int[,] arr)
{
    int minval = arr[0, 0];
    int minidx1=0;
    int minidx2=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (minval > arr[i, j]) { minval = arr[i, j];}
        }
    }
    return minval;
}

//как забрать i, j
(int, int) FindIdx (int[,] arr, int value)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[i, j] == value)
        Console.WriteLine($"Индексы минимального значения i={i} и j={j}");
        return (i, j);        
    }
    }    
}


Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine($"Минимальное число в массиве: {FindMin(array)}");
int deleterow;
int deletecol;
(deleterow, deletecol)=FindIdx


