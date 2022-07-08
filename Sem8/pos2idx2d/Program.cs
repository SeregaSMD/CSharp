void FillArray(int[,] arr)
{
    int counter = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = counter;
            counter++;
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

(int, int) Pos2Idx2D(int[,] array, int position)
{    
    int idx1 = (position - 1) / array.GetLength(1);
    int idx2 = ((position - 1) % array.GetLength(1));
    return (idx1, idx2);
}

int[,] array = new int[3, 2];
FillArray(array);
PrintArray(array);

for (int pos = 1; pos <= array.Length; pos++)
{
    (int index1, int index2) = Pos2Idx2D(array, pos);
    Console.WriteLine($"Элемент на позиции {pos} имеет значение {array[index1, index2]} и индексы {index1} и {index2}");
}