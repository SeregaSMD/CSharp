// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных
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

(int, int) Pos2Idx2D(int[,] array, int position)
{
    int idx1 = (position - 1) / array.GetLength(1);
    int idx2 = ((position - 1) % array.GetLength(0));
    return (idx1, idx2);
}

int Pos2Val2D(int[,] array, int position)
{
    int idx1 = (position - 1) / array.GetLength(1);
    int idx2 = ((position - 1) % array.GetLength(0));
    return array[idx1, idx2];
}

void ArraySort(int[,] arr)
{
    int minPosition = 1;
    int minVal = arr[0, 0];

    for (int sortingPosition = 1; sortingPosition < arr.Length; sortingPosition++)
    {
        minVal = Pos2Val2D(arr, sortingPosition);
        for (int position = sortingPosition+1; position <= arr.Length; position++)
        {
            if (Pos2Val2D(arr, position)<minVal)            
            {                
                minVal = Pos2Val2D(arr, position);
                minPosition = position;
            }
        }
        if (sortingPosition != minPosition) SwapElement(arr, sortingPosition, minPosition);
    }
}

void SwapElement(int[,] arr, int position1, int position2)
{
    (int pos1idx1, int pos1idx2) = Pos2Idx2D(arr, position1);
    (int pos2idx1, int pos2idx2) = Pos2Idx2D(arr, position2);
    int tmp = arr[pos1idx1, pos1idx2];
    arr[pos1idx1, pos1idx2] = arr[pos2idx1, pos2idx2];
    arr[pos2idx1, pos2idx2] = tmp;
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
Console.WriteLine("Сортированный массив:" + array.GetLength(0));
ArraySort(array);
PrintArray(array);

/* int position = 0;
foreach (int element in array)
{
    if (CheckRepeat(array, position, element)) CountFrequency(array, element);
    position++;
} */