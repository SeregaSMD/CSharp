// Написать программу, которая определяет день недели исходя из его номера
Console.Write("Enter weekday number: ");
int weekday = int.Parse(Console.ReadLine());
Console.WriteLine($"Your weekday number is {weekday}");
switch (weekday)
{
    case 1:
        Console.WriteLine("Your weekday is Monday");
        break;
    case 2:
        Console.WriteLine("Your weekday is Tuesday");
        break;
    case 3:
        Console.WriteLine("Your weekday is Wednesday");
        break;
    case 4:
        Console.WriteLine("Your weekday is Thursday");
        break;
    case 5:
        Console.WriteLine("Your weekday is Friday");
        break;
    case 6:
        Console.WriteLine("Your weekday is Saturday");
        break;
    case 7:
        Console.WriteLine("Your weekday is Sunday");
        break;
    case >7:
        Console.WriteLine("Your weekday is out of permissible range");
        break;
}