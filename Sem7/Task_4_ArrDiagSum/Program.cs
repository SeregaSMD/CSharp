// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.



void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //Console.Write(i + " " + j + ", ");
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Fill(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

int DiagSum(int[,] arr)
{
    int diagSum = 0;
    int minSize=Math.Min(arr.GetLength(0), arr.GetLength(1));    
    for (int i = 0; i < minSize; i++)
    {
        diagSum += arr[i, i];
    }
    return diagSum;
}


int m = 3, n = 4;
int[,] mass = new int[m, n];
Fill(mass);
Print(mass);
Console.WriteLine();
DiagSum(mass);
Console.WriteLine($"Сумма элементов главной диагонали равна: {DiagSum(mass)}.");
