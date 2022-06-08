// Написать программу, строит ряд целых чси определяет день недели исходя из его номера
Console.Write("Enter a limit for integer number series: ");
int limit = int.Parse(Console.ReadLine());
Console.Write($"Your limit is {limit}. Integer series for the limit is: ");

int Counter = -limit;

while (Counter <= limit)
{
    Console.Write(Counter + " ");
    Counter++;
}