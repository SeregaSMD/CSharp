// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int m = 3, n = 4;
int[,] mass = new int[m, n];

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
        arr[i, j] = i+j;
    }
}
}
Fill(mass);
Print(mass);
