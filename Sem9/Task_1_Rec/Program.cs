int Rec (int n)
{
    if (n==0)
    {
    Console.WriteLine("Конец!");
    return 1;
    }
    Console.WriteLine("Вызов рекурсии! - " + n);
    return 2 *Rec (n-1);
}

int res = Rec (10);
Console.WriteLine("Результат рекурсии: " + res);
