// Заполните двумерный массив спирально, начиная с 10 с шагом 1 (т.е. 10, 11, 12 и т.д.).
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

int FillRowRight(int[,] arr, int startX, int startY, int lenght, int counter)
{
    for (int j = startX; j <= startX + lenght; j++)
    {
        arr[startY, j] = counter;
        counter++;
    }
    return counter;
}

int FillRowLeft(int[,] arr, int startX, int startY, int lenght, int counter)
{
    for (int j = startX; j >= startX - lenght; j--)
    {
        arr[startY, j] = counter;
        counter++;
    }
    return counter;
}

int FillColUp(int[,] arr, int startX, int startY, int lenght, int counter)
{
    for (int i = startY; i >= startY - lenght; i--)
    {
        arr[i, startX] = counter;
        counter++;
    }
    return counter;
}

int FillColDown(int[,] arr, int startX, int startY, int lenght, int counter)
{
    for (int i = startY; i <= startY + lenght; i++)
    {
        arr[i, startX] = counter;
        counter++;
    }
    return counter;
}

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int col = int.Parse(Console.ReadLine());
int[,] mass = new int[row, col];
int lenghtX = mass.GetLength(1)-1;
int lenghtY = mass.GetLength(0)-2;
int counter = 0;
int startX = 0;
int startY = 0;

while (counter<row*col)
{
counter=FillRowRight(mass,startX,startY,lenghtX,counter);
startX+=lenghtX;
startY++;
lenghtX--;
counter=FillColDown(mass,startX,startY,lenghtY,counter);
startY+=lenghtY;
startX--;
lenghtY--;
counter=FillRowLeft(mass,startX,startY,lenghtX,counter);
startX-=lenghtX;
startY--;
lenghtX--;
counter=FillColUp(mass,startX,startY,lenghtY,counter);
startY-=lenghtY;
startX++;
lenghtY--;
}
PrintArray(mass);
