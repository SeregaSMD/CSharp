// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
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
        array[i] = new Random().Next(0, 2);
    }
}

int[] mass = new int[8];
FillArray(mass);
Console.Write("Созданный массив: ");
PrintArray(mass);
