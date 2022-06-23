//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int sum (int sumlim)
{
if (sumlim<=0)
{
    Console.WriteLine("Введите положительное число!");
    return 0;    
}
else
{
    int sum = 0;
    for (int i=0; i<=sumlim; i++)
    {
        sum+=i;
    }
    return sum;
}
}
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());

Console.Write($"Сумма чисел от 0 до {A} равна: {sum(A)}");