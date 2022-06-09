int num = new Random().Next(100, 1000);

Console.WriteLine($"A random number is: {num}");
string numstr = num.ToString();
Console.WriteLine($"The random number in string format is: {numstr}");
Console.WriteLine($"The first numeral of the number is: {numstr[0]}");
Console.WriteLine($"The second numeral of the number is: {numstr[1]}");
Console.WriteLine($"The third numeral of the number is: {numstr[2]}");

int c1 = num / 100; //первая цифра
int c2 = (num / 10) % 10; //первая цифра
int c3 = num % 10; //третья цифра

Console.WriteLine($"The first numeral of the number is: {c1}");
Console.WriteLine($"The second numeral of the number is: {c2}");
Console.WriteLine($"The third numeral of the number is: {c3}");

Console.WriteLine($"The random number without 2nd numeral is: {c1}{c3}");