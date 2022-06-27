void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

int [] array = new int [5];
FillArray(array);
int [] arraycopy = new int [array.Length];
for (int i=0; i<array.Length; i++)
{
    arraycopy[i]=array[i];
}
// Следует обратить внимание, что команда int [] arraycopy2=array не сработает должным образом, а создаст "ссылку" на исходный массив

Console.Write("Исходный массив: ");
PrintArray(array);
Console.Write("Массив, полученный после поэлементного копирования: ");
PrintArray(arraycopy);