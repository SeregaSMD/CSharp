void FillArray3D(int[,,] arr)
{
    int counter=1;
    for (int z = 0; z < arr.GetLength(2); z++)
    {        
        for (int x = 0; x < arr.GetLength(0); x++)
        {
            for (int y=0; y<arr.GetLength(1); y++)
            {
                arr[x,y,z]=counter;
                counter++;
            }            
        }        
    }
}

void PrintArray3D(int[,,] arr)
{
    for (int z = 0; z < arr.GetLength(2); z++)
    {
        Console.WriteLine($"z={z}");
        for (int x = 0; x < arr.GetLength(0); x++)
        {
            for (int y=0; y<arr.GetLength(1); y++)
            {
                Console.Write(arr[x, y, z] + " ");
            }
            Console.WriteLine();
        }        
    }
}

(int, int, int) Pos2Idx3D (int [,,] array, int position)
{    
    int idx1=(position-1)%(array.GetLength(0)*array.GetLength(1))%array.GetLength(1);
    int idx2=(position-1)%(array.GetLength(0)*array.GetLength(1))/array.GetLength(0);
    int idx3=(position-1)/(array.GetLength(0)*array.GetLength(1));
    return (idx1, idx2, idx3);
}

int [,,] array = new int [3,4,2];
FillArray3D(array);
PrintArray3D(array);

for (int pos=1; pos<=array.Length; pos++)
{
(int index1, int index2, int index3)=Pos2Idx3D(array,pos);
Console.WriteLine($"{pos} элемент имеет индексы {index1}, {index2}, {index3}");
}