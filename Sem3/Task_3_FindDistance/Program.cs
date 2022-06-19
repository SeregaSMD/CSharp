// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
Console.Write("Enter first X coordinate: ");
double X1 = double.Parse(Console.ReadLine());
Console.Write("Enter first Y coordinate: ");
double Y1 = double.Parse(Console.ReadLine());
Console.Write("Enter second X coordinate: ");
double X2 = double.Parse(Console.ReadLine());
Console.Write("Enter second Y coordinate: ");
double Y2 = double.Parse(Console.ReadLine());
double dist = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
Console.WriteLine($"Distance between your points is (with a precision up to 2 digits): {Math.Round(dist, 2)}");