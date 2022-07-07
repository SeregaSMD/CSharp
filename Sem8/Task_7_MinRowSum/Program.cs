//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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