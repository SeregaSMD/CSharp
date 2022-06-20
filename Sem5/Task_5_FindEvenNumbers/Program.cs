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
        array[i] = new Random().Next(100, 1000);
    }
}

Console.Write("Введите размерность массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] mass = new int[arraySize];

FillArray(mass);
Console.Write("Созданный массив: ");
PrintArray(mass);

int counter=0;

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i]%2 == 0)
    {
        counter++;
    }       
}

Console.Write($"Количество четных чисел в вашем массиве: {counter}.");