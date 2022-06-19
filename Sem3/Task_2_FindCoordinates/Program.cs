// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Write("Enter sector number: ");
int sec = int.Parse(Console.ReadLine());
if (sec == 1)
{
    Console.WriteLine("The first sector contains points with the following coordinates: X>0 and Y>0.");
}
else if (sec == 2)
{
    Console.WriteLine("The second sector contains points with the following coordinates: X<0 and Y>0.");
}
else if (sec == 3)
{
    Console.WriteLine("The third sector contains points with the following coordinates: X<0 and Y<0.");
}
else if (sec == 4)
{
    Console.WriteLine("The fourth sector contains points with the following coordinates: X>0 and Y<0.");
}
else
{
    Console.WriteLine("Your number is out of permissible range. Please enter an integer number from 1 to 4.");
}