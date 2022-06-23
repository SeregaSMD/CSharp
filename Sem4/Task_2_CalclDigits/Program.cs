//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
int count = 0;
while (num > 0)
{
    num = num /10;
    count++;
}
Console.WriteLine("Введенное число имеет " + count + " знаков.");