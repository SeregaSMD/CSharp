// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
int prod (int prodlim)
{
if (prodlim<=0)
{
    Console.WriteLine("Введите положительное число!");
    return 0;    
}
else
{
    int prod = 1;
    for (int i=1; i<=prodlim; i++)
    {
        prod=prod*i;
    }
    return prod;
}
}
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());

Console.Write($"Произведение чисел от 0 до {A} равна: {prod(A)}");