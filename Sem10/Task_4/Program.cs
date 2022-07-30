//: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info.
// Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

void PrintArray(int[] arr)
{ 
    
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    
}


int [] data = {0,0,1,1,0,0,1,1,0};
int [] info = {2,3,3,1};

int [] cdata = new int [info.Length];

int k=0;

for (int i = 0; i < info.Length; i++)
{
    for (int j = info[i]-1, m=0; j >= 0; j--,m++)
    {
        
        Console.Write($"{data[m+k]}");

        
        cdata[i]+=(int)(data[j+k]*Math.Pow(2,m));
        
    }
        
    k+=info[i];
    Console.WriteLine();
}
PrintArray(cdata);


