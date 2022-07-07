// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
void Print(int[,] arr)
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

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int col = int.Parse(Console.ReadLine());
int[,] mass = new int[row, col];
int lenghtX = mass.GetLength(1)-1;
int lenghtY = mass.GetLength(0)-2;
int counter = 1;
int startX = 0;
int startY = 0;
int finishX = 0;
int finishY = 0;
Print(mass);
Console.WriteLine($"startX={startX}");
Console.WriteLine($"startY={startY}");
Console.WriteLine($"counter={counter}");
Console.WriteLine($"lenghtX={lenghtX}");
Console.WriteLine($"lenghtY={lenghtY}");

(int, int, int) FillRight(int[,] arr, int startX, int startY, int lenght, int counter)
{
    for (int i = startY; i < startY + lenght; i++)
    {
        arr[startX, i] = counter;
        counter++;
    }
    return (startX+1, startY + lenght, counter);
}

(int, int, int) FillDown(int[,] arr, int startX, int startY, int lenght, int counter)
{
    for (int i = startX; i < startX + lenght; i++)
    {
        arr[i, startY] = counter;
        counter++;
    }
    return (startX+lenght, startY-1, counter);
}

(int, int, int) FillLeft(int[,] arr, int startX, int startY, int lenght, int counter)
{
    for (int i = startY; i > startY - lenght; i--)
    {
        arr[startX, i] = counter;
        counter++;
    }
    return (startX-1, startY + lenght+1, counter);
}

(int, int, int) FillUp(int[,] arr, int startX, int startY, int lenght, int counter)
{
    for (int i = startY; i < startY + lenght; i++)
    {
        arr[startX, i] = counter;
        counter++;
    }
    return (startX, startY + lenght, counter);
}
while (counter <17)
{
(finishX, finishY, counter) = FillRight(mass, startX, startY, lenghtX, counter);
lenghtX--;
(finishX, finishY, counter) = FillDown(mass, finishX, finishY, lenghtY, counter);
lenghtY--;
(finishX, finishY, counter) = FillLeft(mass, finishX, finishY, lenghtX, counter);
lenghtX--;
(finishX, finishY, counter) = FillUp(mass, finishX, finishY, lenghtY, counter);
lenghtY--;
}
Print(mass);
