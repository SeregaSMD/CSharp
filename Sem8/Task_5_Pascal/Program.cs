int Factorial(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact = fact * i;
    }
    return fact;
}

int Binom(int n, int m)
{
    return Factorial(n) / (Factorial(m) * Factorial(n - m));
}

int CountDigits(int num)
{
    int countDigits = 0;
    while (num > 0)
    {
        num = num / 10;
        countDigits++;
    }
    return countDigits;
}

int CalcPascalLineLenght(int line)
{
    int lineLenght = 0;
    for (int j = 0; j <= line; j++)
    {
        lineLenght += CountDigits(Binom(line, j)) + 1;
    }
    return lineLenght;
}

Console.Clear();
Console.Write("Введите число строк треугольника Паскаля (начиная с 0): ");
int number = int.Parse(Console.ReadLine());

int lastLineLenght = CalcPascalLineLenght(number);
(int consoleLeftStart, int consoleTopStart) = Console.GetCursorPosition();

for (int i = 0; i <= number; i++)
{
    consoleLeftStart = (CalcPascalLineLenght(number) - CalcPascalLineLenght(i)) / 2;
    Console.SetCursorPosition(consoleLeftStart, consoleTopStart);
    for (int j = 0; j <= i; j++)
    {
        Console.Write(Binom(i, j) + " ");
    }
    consoleTopStart++;
}