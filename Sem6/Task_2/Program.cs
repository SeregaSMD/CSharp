Console.Write("Введите длину первой стороны треугольника: ");
int len1 = int.Parse(Console.ReadLine());
Console.Write("Введите длину второй стороны треугольника: ");
int len2 = int.Parse(Console.ReadLine());
Console.Write("Введите длину третьей стороны треугольника: ");
int len3 = int.Parse(Console.ReadLine());
if ((len1>len2+len3) || (len2>len1+len3) || (len3>len2+len3))
{
Console.Write("Такой треугольник не существует.");
}
else
{
    Console.Write("Такой треугольник существует.");
}