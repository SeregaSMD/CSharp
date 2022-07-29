//-----------------------------------------------------------------------------------------------------------------------
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//-----------------------------------------------------------------------------------------------------------------------

void FillArray(int[,] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);          
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

void ArraySortRow(int[,] arr, int row)
{
    int maxVal = 0;
    int maxIdx = 0;
    int tmpVal = 0;
    for (int counter = 0; counter < arr.GetLength(1); counter++)
    {
        maxVal = arr[row, counter];
        for (int j = counter+1; j < arr.GetLength(1); j++)
        {
            if (arr[row, j] > maxVal)
            {                
                maxIdx = j;
                maxVal = arr[row, j];
            }
        }
        Swap(arr, counter, maxIdx, row);
    }
}

void Swap(int[,] arr, int idx1, int idx2, int row)
{
    int tmp = arr[row, idx1];
    arr[row, idx1] = arr[row, idx2];
    arr[row, idx2] = tmp;
}

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);

Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine("Сортированный массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    ArraySortRow(array, i);
}
PrintArray(array);

//------------------------------------------------------------------------------------------------------------------------
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//------------------------------------------------------------------------------------------------------------------------
void FillArray(int[,] arr)
{    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);
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

int ArrayRowSum(int[,] arr, int row)
{
    int rowSum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        rowSum += arr[row, j];
    }
    Console.WriteLine(rowSum);
    return rowSum;
}

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);

Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine("Сумма по строкам составит: ");
int[] rowSum = new int[array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++)
{
    rowSum[i] = ArrayRowSum(array, i);
}

int FindMin(int[] arr)
{
    int minVal = arr[0];
    int minIdx=0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i]<minVal)
        {
            minVal=arr[i];
            minIdx=i;
        }

    }
    return minIdx;
}
Console.WriteLine($"Наименьшая сумма элементов наблюдается в строке {FindMin(rowSum)} и составляет {rowSum[FindMin(rowSum)]}.");

//-----------------------------------------------------------------------------------------
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//-----------------------------------------------------------------------------------------

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);
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

Console.Write("Введите кол-во строк матрицы A: ");
int dimA1 = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов матрицы A: ");
int dimA2 = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во строк матрицы B: ");
int dimB1 = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов матрицы B: ");
int dimB2 = int.Parse(Console.ReadLine());

int[,] matrixA = new int[dimA1, dimA2];
int[,] matrixB = new int[dimB1, dimB2];

FillArray(matrixA);
FillArray(matrixB);

int[,] MatrixProd = new int[dimA2, dimB1];

for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        for (int k = 0; k < matrixA.GetLength(1); k++)
        {
            MatrixProd[i, k] += matrixA[i, k] * matrixB[k, j];
        }
    }
}

Console.WriteLine("Исходный массив A:");
PrintArray(matrixA);
Console.WriteLine("Исходный массив B:");
PrintArray(matrixB);
Console.WriteLine("Результат умножения матриц A и B:");
PrintArray(MatrixProd);

//------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//------------------------------------------------------------------------------------------------------------------------------------------------------------------
void FillArray3D(int[,,] arr)
{
    bool repeat = true;
    int counter = 0;
    int rndVal=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {


                while (repeat)
                {
                    rndVal = new Random().Next(10, 100);
                    repeat=CheckRepeat(arr, counter, rndVal);
                    }
                arr[i,j,k]=rndVal;
                repeat = true;
                counter++;


            }
        }
    }
}

void PrintArray3D(int[,,] arr)
{    
        for (int x = 0; x < arr.GetLength(0); x++)
        {
            for (int y = 0; y < arr.GetLength(1); y++)
            {
                for (int z=0; z<arr.GetLength(2); z++)
                {
                Console.WriteLine($"Элемент с индексами {x}, {y} и {z} содержит следующее значение: {arr[x, y, z]}");
                }
            }            
        }
    }


bool CheckRepeat(int[,,] arr, int elemPos, int elemVal)
{
    int pos = 0;
    foreach (int element in arr)
    {
        if (element == elemVal && pos < elemPos) return true;
        pos++;
    }
    return false;
}

int position = 0;
int[,,] array = new int[5, 4, 3];
FillArray3D(array);
PrintArray3D(array);

//---------------------------------------------------------------------------------------
// Заполните двумерный массив спирально, начиная с 10 с шагом 1 (т.е. 10, 11, 12 и т.д.).
//---------------------------------------------------------------------------------------
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
