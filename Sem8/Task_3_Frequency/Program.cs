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

void CountFrequency(int[,] arr, int element)
{
    int counter = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            if (arr[i, j] == element) counter++;
        }

    }
    Console.WriteLine($"{element} встречается {counter} раз");
}

bool CheckArray(int[,] arr, int idx, int elem)
{
    int counter = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (counter==idx) return true;
            if (arr[i, j] == elem) return false;
            counter++;
        }
    }
    return true;
}

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
int counter=0;
foreach (int elem in array)
{
    if (CheckArray(array, counter, elem)) CountFrequency(array, elem);
    counter++;
}

// создать отдельный массив с уникальными элементами