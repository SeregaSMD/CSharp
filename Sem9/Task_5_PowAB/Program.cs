//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите степень в которую его возвести: ");
int power = int.Parse(Console.ReadLine());

int PowAB (int num, int pow)
{
    if (pow == 0) return 1;
    return PowAB(num, pow-1) * num;
}

Console.WriteLine(PowAB(number, power));