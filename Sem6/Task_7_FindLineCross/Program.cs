// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Данная программа находет пересечение прямых вида y=ax+b");
Console.Write("Введите коэффициент k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите коэффициент b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите коэффициент k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите коэффициент b2: ");
double b2 = double.Parse(Console.ReadLine());

if (k1 == k2) { Console.Write("Описанные прямые паралельны, пересечение отсутствует."); }
else
{
    double x = (b2 - b1) / (k1 - k2);
    Console.Write($"Координаты точка пересечения описанных прямых: x={x}, y={k1 * x + b1}.");
}