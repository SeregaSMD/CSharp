//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void FillArray3D(int[,,] arr)
{
    bool repeat = true;
    int counter = 0;
    int rndVal=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {


                while (repeat)
                {
                    rndVal = new Random().Next(10, 100);
                    repeat=CheckRepeat(arr, counter, rndVal);
                    }
                arr[i,j,k]=rndVal;
                repeat = true;
                counter++;


            }
        }
    }
}

void PrintArray3D(int[,,] arr)
{
    
    
    
        for (int x = 0; x < arr.GetLength(0); x++)
        {
            for (int y = 0; y < arr.GetLength(1); y++)
            {
                for (int z=0; z<arr.GetLength(2); z++)
                {
                Console.WriteLine($"Элемент с индексами {x}, {y} и {z} содержит следующее значение: {arr[x, y, z]}");
                }
            }            
        }
    }


bool CheckRepeat(int[,,] arr, int elemPos, int elemVal)
{
    int pos = 0;
    foreach (int element in arr)
    {
        if (element == elemVal && pos < elemPos) return true;
        pos++;
    }
    return false;
}

int position = 0;
int[,,] array = new int[5, 4, 3];
FillArray3D(array);
PrintArray3D(array);