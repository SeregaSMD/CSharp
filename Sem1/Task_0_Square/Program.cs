// Написать программу, которая на вход приниамет число и выдает его квадрат

Console.Write("Enter a number: ");
double number = double.Parse(Console.ReadLine());
double number_square = Math.Pow(number, 2);
Console.WriteLine($"Your number is {number}");
Console.Write("The square of the number is " + number_square);
