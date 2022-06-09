int num = new Random().Next(10, 100);

Console.WriteLine(num);

int c1 = num / 10;
int c2 = num % 10;

if (c1<c2)
{
    Console.WriteLine(c2);
}
else
{
    Console.WriteLine(c1);
}