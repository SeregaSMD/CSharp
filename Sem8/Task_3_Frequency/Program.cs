// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных
void FillArray(int[,] arr)
{    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);            
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

bool CheckRepeat(int[,] arr, int elemPos, int elemVal)
{
    int pos = 0;
    foreach (int element in arr)
    {
        if (element == elemVal && pos < elemPos) return false;
        pos++;
    }
    return true;
}

(int, int) FindArrayMinIdx(int[,] arr, int startI, int startJ) // ищет минимум в 2D массиве начиная с определенной позиции элемента
{
    int minI=startI;
    int minJ=startJ;
    int minVal=arr[startI,startJ];
    for (int i = startI; i < arr.GetLength(0); i++)
    {        
        for (int j = startJ; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < minVal)
            {
                minVal = arr[i, j];
                minI = i;
                minJ = j;
            }
        }
        startJ = 0;
    }
    return (minI, minJ);
}

int [,] ArraySort (int [,] arr)
{
    int minI=0;
    int minJ=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            (minI, minJ)=FindArrayMinIdx(arr,i,j);
            if (minI!=i || minJ!=j) Swap (arr, i, j, minI, minJ);
        }
    }
    return arr;
}

void Swap(int[,] arr, int i, int j, int minI, int minJ)
{   
    int tmp = arr[i, j];
    arr[i, j] = arr[minI, minJ];
    arr[minI, minJ] = tmp;
}

void CountFrequency(int[,] arr, int elemVal)
{
    int counter = 0;
    foreach (int element in arr)
    {
        if (element == elemVal) counter++;
    }
    Console.WriteLine($"{elemVal} встречается {counter} раз");
}

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);

Console.WriteLine("Исходный массив:");
PrintArray(array);
array=ArraySort(array);

int position = 0;
foreach (int element in array)
{
    if (CheckRepeat(array, position, element)) CountFrequency(array, element);
    position++;
}