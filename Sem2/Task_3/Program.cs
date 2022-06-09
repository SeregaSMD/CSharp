int num = new Random().Next(100, 1000);

Console.WriteLine($"Случайное число: {num}");

int c1 = num / 100; //первая цифра
int c3 = num % 10; //третья цифра

Console.WriteLine($"Первая цифра в случайном числе является: {c1}");
Console.WriteLine($"Третья цифра в случайном числе является: {c3}");

Console.WriteLine($"Случайное число без 2 цифры: {c1}{c3}");