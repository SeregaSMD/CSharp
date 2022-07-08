//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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