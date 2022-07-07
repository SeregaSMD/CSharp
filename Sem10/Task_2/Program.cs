Console.Clear();
int SumPreviosTwo(int numberStart, int numberSecond, int number)
{
    if (number == 1) return numberStart;

    if (number == 2) return numberSecond;

    return SumPreviosTwo(numberStart, numberSecond, number - 1) + SumPreviosTwo(numberStart, numberSecond, number - 2);
}


Console.WriteLine("Введите numberStart");
int numberStart = int.Parse(Console.ReadLine());
Console.WriteLine("Введите numberFinish");
int numberSecond = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();


Console.Write(SumPreviosTwo(numberStart, numberSecond, number));
