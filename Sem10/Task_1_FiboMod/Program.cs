//Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество чисел последовательности: ");
int seriesLenght = int.Parse(Console.ReadLine());
int counter=0;
Console.WriteLine(number1);
Console.WriteLine(number2);

void FiboMod (int number1, int number2, int counter, int seriesLenght)
{
    if (counter==seriesLenght) return;    
    Console.WriteLine(number1+number2);
    counter++;
    FiboMod(number2, number1+number2, counter, seriesLenght);
}

FiboMod(number1,number2, counter, seriesLenght);