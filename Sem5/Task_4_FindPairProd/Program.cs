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

Console.Write("Введите размерность массива: ");
int arraySize = int.Parse(Console.ReadLine());

int[] mass = new int[arraySize];
FillArray(mass);
Console.Write("Созданный массив: ");
PrintArray(mass);

int arraySize2 = (mass.Length+1)/2;
int[] massPair = new int[arraySize2];

massPair[massPair.Length-1]=mass[mass.Length/2];

for (int i = 0; i < mass.Length/2; i++)
{
    massPair[i]=mass[i]*mass[arraySize-1-i];
}

Console.Write("Созданный массив пар: ");
PrintArray(massPair);