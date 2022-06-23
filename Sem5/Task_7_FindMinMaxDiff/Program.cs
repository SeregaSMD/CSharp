// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((new Random().Next(0, 100)) + new Random().NextDouble(), 2);        
    }
}

Console.Write("Введите размерность массива: ");
int arraySize = int.Parse(Console.ReadLine());
double [] mass = new double[arraySize];

FillArray(mass);
Console.Write("Созданный массив: ");
PrintArray(mass);

int minidx = 0;
double minval = mass[0];
int maxidx = 0;
double maxval = mass[0];

for (int i=0; i<mass.Length; i++)
{
    if (mass[i]<minval)
    {
        minval=mass[i];    
    }
    if (mass[i]>maxval)
    {
        maxval=mass[i];    
    }
}
double diffMaxMin=maxval-minval;
Console.WriteLine($"Разность между max {maxval} и min {minval} элементами массива mass равна " + diffMaxMin);