// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Решение через числа
Console.Write("Enter an integer 5-digit number: ");
int num = int.Parse(Console.ReadLine());

int digitCount = (int)Math.Log10(num) + 1;
Console.WriteLine(digitCount);

if (num > 9999 && num < 100000)
{
    int c5 = num % 10;
    int c4 = (num /10) % 10;
    int c2 = (num /1000) % 10;
    int c1 = (num /10000) % 10;
    if ((c1 == c5) && (c2 == c4))
    {
        Console.WriteLine("Your number is a palindrome");
    }
    else
    {
        Console.WriteLine("Your number is not a palindrome");
    }
}
else
Console.Write("Your number is not a 5-digit integer. Please enter a correct number.");

// // Решение через строки
// Console.Write("Enter an a 5-character string: ");
// String num = Console.ReadLine();
// if (num.Length == 5)
// {
//     if ((num[0] == num[4]) && (num[1] == num[3]))
//     {
//         Console.WriteLine("Your string is a palindrome");
//     }
//     else
//     {
//         Console.WriteLine("Your string is not a palindrome");
//     }
// }
// else
// Console.Write("Your string is not a 5-character string. Please enter a correct string.");