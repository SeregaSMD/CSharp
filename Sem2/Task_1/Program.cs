void FillArray(int[] array)
{
    int lenght = array.Length;
    int index = 0;
    while (index < lenght)
    {
        array[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] array)
{
    int lenght = array.Length;
    int index = 0;
    while (index < lenght)
    {
        Console.WriteLine(array[index]);
        index++;
    }
}

int IndexOf(int[] array, int find)
{
    int lenght = array.Length;
    int index = 0;
    int position = 0;

    while (index < lenght)
    {
        if(array[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);