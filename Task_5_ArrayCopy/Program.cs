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

int [] arraycopy2=array;

PrintArray(array);
PrintArray(arraycopy);
PrintArray(arraycopy2);
array[0]=53;
PrintArray(array);
PrintArray(arraycopy2);