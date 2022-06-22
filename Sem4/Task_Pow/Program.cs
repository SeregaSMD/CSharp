// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.Write($"Введите стпепнь в которую возвести число {A}: ");
int B = int.Parse(Console.ReadLine());
int pow = A;
for (int i=1; i<B; i++)
{
    pow = pow * A; 
}
Console.WriteLine($"Результат возведения {A} в степень {B}: {pow}.");