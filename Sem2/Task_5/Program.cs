Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number%7 == 0 && number%23 == 0)
{
    Console.WriteLine($"Введенное число кратно 7 и 23.");
}
else
{
    Console.WriteLine($"Введенное число не кратно одновременно 7 и 23.");
}