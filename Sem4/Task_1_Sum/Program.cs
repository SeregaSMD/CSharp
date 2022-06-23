//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
if (A<0)
{
    Console.WriteLine("Введите положительное число!");
    return;
}
else
{
int sum = 0;
for (int i=0; i<=A; i++)
{
    sum += i;
}
Console.Write($"Сумма чисел от 0 до {A} равна: {sum}");
}