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

Console.WriteLine("Введите число строк треугольника Паскаля (начиная с 0): ");
int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(Binom(i, j) + " ");
    }
    Console.WriteLine();
}