void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("Введите размер массива");
int arraylen = int.Parse(Console.ReadLine());

int[] array = new int [arraylen];

for (int i=0; i<arraylen; i++)
{
    Console.Write($"Введите {i+1} элемент массива: ");
    array[i]=int.Parse(Console.ReadLine());
}
PrintArray(array);

int count=0;
for (int i=0; i<arraylen; i++)
{
    if (array[i]>0)
    {
        count++;
    }    
}