int num = new Random().Next(10, 100);

Console.WriteLine($"Random number is: {num}");

int c1 = num / 10; //первая цифра
int c2 = num % 10; //вторая цифра

if (c1<c2)
{
    Console.WriteLine($"The largest numeral in the number is: {c2}");
}
else
{
    Console.WriteLine($"The largest numeral in the number is: {c1}");
}