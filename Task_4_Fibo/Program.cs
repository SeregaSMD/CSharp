void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите число для которого будет построен ряд Фибоначчи: ");
int fiblim = int.Parse(Console.ReadLine());
int [] fib = new int [fiblim];
if (fiblim>2)
{
fib[0]=0;
fib[1]=1;
for (int i=2; i<fiblim; i++)
{
    fib[i]=fib[i-2]+fib[i-1];
}
}
else if (fiblim==2)
{
fib[0]=0;
fib[1]=1;
}
else if (fiblim==1)
{
    fib[0]=0;
}

PrintArray(fib);