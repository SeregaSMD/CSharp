//Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info.
//Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] Transform2to10(int[] data2, int [] info2, int [] data10)
{
    int corrector = 0;
    for (int i = 0; i < info2.Length; i++)
    {
        for (int j = 0, m = info2[i] - 1; j < info2[i]; j++, m--)
        {
            Console.Write($"{data2[j + corrector]}");
            data10[i] += (int)(data2[j + corrector] * Math.Pow(2, m));
        }
        corrector += info2[i];
        Console.WriteLine();
    }
    return data10;
}

int[] data2 = { 0, 1, 0, 1, 1, 0, 0, 0, 1 };
int[] info2 = { 3, 2, 3, 1 };

int[] data10 = new int[info2.Length];
data10=Transform2to10(data2,info2,data10);

PrintArray(data10);