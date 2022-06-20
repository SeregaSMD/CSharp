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
        array[i] = new Random().Next(0, 100);
    }
}

Console.Write("Введите размерность массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] mass = new int[arraySize];

FillArray(mass);
Console.Write("Созданный массив: ");
PrintArray(mass);

int SumNotEven=0;

for (int i = 0; i < mass.Length; i+=2)
{
    SumNotEven+=mass[i];
}

Console.Write($"Сумма чисел стоящих на нечетных местах: {SumNotEven}.");