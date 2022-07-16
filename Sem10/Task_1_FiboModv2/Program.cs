//Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FiboMod (int [] numbers, int seriesLenght, int counter)
{
    if (counter==seriesLenght) return;            
    numbers[counter+2]=numbers[counter+1]+numbers[counter];    
    counter++;
    FiboMod(numbers, seriesLenght, counter);
}

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество чисел последовательности: ");
int seriesLenght = int.Parse(Console.ReadLine());
int [] numbers = new int [seriesLenght+2];
numbers[0]=number1;
numbers[1]=number2;
int counter=0;

FiboMod(numbers, seriesLenght, counter);
PrintArray(numbers);