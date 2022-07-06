int Akkerman (int m, int n)
{
if (m==0) return n+1;
if (m>0 && n==0) return Akkerman(m-1, 1);
if (m>0 && n>0) return Akkerman (m-1, Akkerman(m, n-1));
else return -100500;
}

Console.Write ("Введите число m: ");
int m=int.Parse(Console.ReadLine());
Console.Write ("Введите число n: ");
int n=int.Parse(Console.ReadLine());
Console.WriteLine ($" функция Аккермана для m={m} и n={n} равна {Akkerman (m,n)}");