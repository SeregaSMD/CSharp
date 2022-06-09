Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number2%number1 == 0)
{
    Console.WriteLine("Второе число кратно первому.");
}
else
{
    Console.WriteLine($"Второе число не кратно первому. Остаток от деления составит {number2%number1}.");
}