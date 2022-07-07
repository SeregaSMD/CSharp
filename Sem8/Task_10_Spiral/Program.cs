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

(int, int, int) FillRow(int[,] arr, int startX, int startY, int lenght, int counter)
{
    for (int i = startX; i < startX + lenght; i++)
    {
        arr[startY, i] = counter;
        counter++;
    }
    return (startX+1, startY + lenght - 1, counter);
}

(int, int, int) FillCol(int[,] arr, int startX, int startY, int lenght, int counter)
{
    for (int j = 0; j < startY + lenght; j++)
    {
        arr[j, startX] = counter;
        counter++;
    }
    return (startX + lenght - 1, startY, counter);
}


Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int col = int.Parse(Console.ReadLine());
int[,] mass = new int[row, col];
int lenghtX = mass.GetLength(0);
int lenghtY = mass.GetLength(1) - 1;
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
//while (counter<16)

(finishX, finishY, counter) = FillRow(mass, startX, startY, lenghtX, counter);
lenghtX--;
lenghtX = lenghtX * -1;
Console.WriteLine($"finishX={finishX}");
Console.WriteLine($"finishY={finishY}");
Console.WriteLine($"counter={counter}");
Console.WriteLine($"lenghtX={lenghtX}");
Console.WriteLine($"lenghtY={lenghtY}");
Print(mass);
(finishX, finishY, counter) = FillCol(mass, finishX, finishY, lenghtY, counter);
lenghtY--;
lenghtX = lenghtX * -1;

Print(mass);
