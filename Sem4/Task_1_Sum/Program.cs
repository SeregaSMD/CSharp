Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
int sum = 0;
for (int i=0; i<=A; i++)
{
    sum += i;
}
Console.Write($"Сумма чисел от 0 до {A} равна: {sum}");