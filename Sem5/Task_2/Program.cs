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
        array[i] = new Random().Next(-10, 11);
    }
}
Console.Write("Введите размерность массива: ");
int arraySize = int.Parse(Console.ReadLine());

Console.Write("Введите искомое число: ");
int findNum = int.Parse(Console.ReadLine());

int[] mass = new int[arraySize];
FillArray(mass);
Console.Write("Созданный массив: ");
PrintArray(mass);

bool found = false;

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] == findNum)
    {
        Console.WriteLine($"Элемент найден, его индекс (первое вхождение) в массиве равен {i}");
        found =true;
        break;
    }
    
    
}
if (!found)
{
Console.WriteLine("Элемент не найден");
}