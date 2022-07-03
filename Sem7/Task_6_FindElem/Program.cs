// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

void Print(double[,] arr)
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

double PrintElem(double[,] arr, int idx0, int idx1)
{
    double elem;
    if (arr.GetLength(0)-1>idx0 && arr.GetLength(1)-1>idx1)
    {
        return elem = arr [idx0, idx1];
    }
    else
    {
        return elem = -100500;
    }
}

Console.Write("Введите первый размер массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите второй размер массива: ");
int n = int.Parse(Console.ReadLine());
double[,] mass = new double[m, n];
Fill(mass);
Print(mass);

Console.Write("Введите первый идекс элемента массива: ");
int idx0 = int.Parse(Console.ReadLine());
Console.Write("Введите второй идекс элемента массива: ");
int idx1 = int.Parse(Console.ReadLine());
double elem = PrintElem(mass, idx0, idx1);
if (elem!=-100500)
{
    Console.Write($"Выбранный элемент массива равен: {elem}.");
}
else
{
    Console.Write($"Выбранный элемент не существует.");
}