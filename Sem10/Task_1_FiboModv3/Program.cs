//Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
int FiboMod(int number1, int number2, int number)
{
    if (number==0) return number1;
    if (number==1) return number2;
    if (number>1) return FiboMod(number1, number2, number-1)+FiboMod(number1, number2, number-2);    
    else return -100500;
}

Console.Write("Введите первое число последовательности: ");
int number1=int.Parse(Console.ReadLine());
Console.Write("Введите второе число последовательности: ");
int number2=int.Parse(Console.ReadLine());
Console.Write("Введите длину последовательности: ");
int seriesLenght=int.Parse(Console.ReadLine());

for (int i=0; i<seriesLenght;i++)
{
    Console.WriteLine(FiboMod(number1, number2, i));
}