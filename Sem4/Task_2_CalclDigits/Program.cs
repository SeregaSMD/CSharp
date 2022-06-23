//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
int digits (int number)
{
 int count = 0;
while (number != 0)
{
    number = number /10;
    count++;
}   
return count;
}

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Введенное число имеет " + digits(num) + " знаков.");