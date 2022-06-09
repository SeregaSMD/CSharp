//----------------------------------------------------------------------------------------------------
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//----------------------------------------------------------------------------------------------------

int num = new Random().Next(100, 1000);

Console.WriteLine($"A random number is: {num}");

/* Преобразование в строку является сложной операцией и ее стоит избегать
string numstr = num.ToString();
Console.WriteLine($"The random number in string format is: {numstr}");
Console.WriteLine($"The first numeral of the number is: {numstr[0]}");
Console.WriteLine($"The second numeral of the number is: {numstr[1]}");
Console.WriteLine($"The third numeral of the number is: {numstr[2]}");
*/

int char1 = num / 100; //первая цифра
int char2 = (num / 10) % 10; //вторая цифра
int char3 = num % 10; //третья цифра

Console.WriteLine($"The first numeral of the number is: {char1}");
Console.WriteLine($"The second numeral of the number is: {char2}");
Console.WriteLine($"The third numeral of the number is: {char3}");

Console.WriteLine($"The random number without 2nd numeral is: {char1}{char3}");