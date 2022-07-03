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
        arr[i, j] = new Random().Next(0, 10);
    }
}
}

void FindEvenIdx (int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i+=2)
{
    for (int j = 0; j < arr.GetLength(1); j+=2)
    {
        arr[i,j]=arr[i,j]*arr[i,j];        
    }
}
}
Fill(mass);
Print(mass);
Console.WriteLine();
FindEvenIdx(mass);
Print(mass);
