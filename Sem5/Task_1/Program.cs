void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(-10,11);
    }
}
Console.Write("Введите размерность массива: ");
int arraySize = int.Parse(Console.ReadLine());

int[] mass = new int[arraySize];
FillArray(mass);
Console.WriteLine("Старый массив");
PrintArray(mass);

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = mass[i]*-1;    
}

Console.WriteLine();
Console.WriteLine("Новый массив");
PrintArray(mass);












// void FillArray(int[] array)
// {
//     int lenght = array.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         array[index] = new Random().Next(1,10);
//         index++;
//     }
// }

// void PrintArray(int[] array)
// {
//     int lenght = array.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         Console.WriteLine(array[index]);
//         index++;
//     }
// }

// int IndexOf(int[] array, int find)
// {
//     int lenght = array.Length;
//     int index = 0;
//     int position = 0;

//     while (index < lenght)
//     {
//         if(array[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int [10];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// int pos = IndexOf(array, 4);
// Console.WriteLine(pos);