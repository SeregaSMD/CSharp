//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int idx = 1;
Console.WriteLine($"Here we have the cubes for a number series ending with the number {num}: ");
if (num>0 && num<2147483647)
{
    while (idx < num)
{
    Console.Write($"{Math.Pow (idx, 3)}, ");
    idx++;
}
Console.Write($"{Math.Pow (idx, 3)}.");
}
else
{
    Console.WriteLine($"Your number is out of permissible range. Please enter an integer number between 1 and 2 147 483 647");
}
