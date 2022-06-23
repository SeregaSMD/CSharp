void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.Write("Введите десятичное число: ");
int num10 = int.Parse(Console.ReadLine());
int tmp = num10;
int count = 0;

while (num10 !=0)
{    
    num10 = num10 / 2;
    count++;   
}

Console.WriteLine(count);
int [] num10ar = new int [count];

for (int i=count-1; i>=0; i--)
{
    num10ar[i] = (tmp % 2);
    tmp = tmp / 2;    
}

PrintArray(num10ar);