// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Write("Enter X coordinate: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Enter Y coordinate: ");
int Y = int.Parse(Console.ReadLine());
if (X > 0 && Y > 0)
{
    Console.WriteLine("Your coordinates belong to sector 1.");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Your coordinates belong to sector 2.");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Your coordinates belong to sector 3.");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Your coordinates belong to sector 4.");
}
else
{
    Console.WriteLine("One or both coordinates are zero. There is no answer.");
}