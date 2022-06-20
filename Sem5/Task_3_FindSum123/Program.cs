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
        array[i] = new Random().Next(0, 200);
    }
}
int arraySize = 123;
int[] mass = new int[arraySize];
FillArray(mass);
Console.Write("Созданный массив: ");
PrintArray(mass);

int SumArray = 0;

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] >=10 && mass[i] <=99)
    {
        SumArray=SumArray+mass[i];        
    }   
}
Console.WriteLine($"Сумма элементов между [10, 99] равна {SumArray}");      