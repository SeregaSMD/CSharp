int num = new Random().Next(10, 100);

Console.WriteLine($"Случайное число: {num}");

int c1 = num / 10; //первая цифра
int c2 = num % 10; //вторая цифра

if (c1<c2)
{
    Console.WriteLine($"Наибольшей цифрой в случайном числе является: {c2}");
}
else
{
    Console.WriteLine($"Наибольшей цифрой в случайном числе является: {c1}");
}