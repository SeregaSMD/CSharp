// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void Print(double[,] arr)
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

void Fill(double[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = Math.Round(new Random().Next(0, 10) + new Random().NextDouble(), 2);
    }
}
}

Console.Write("Введите первый размер массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите второй размер массива: ");
int n = int.Parse(Console.ReadLine());
double[,] mass = new double[m, n];
Fill(mass);
Print(mass);
