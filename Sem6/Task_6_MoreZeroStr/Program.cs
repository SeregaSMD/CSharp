//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.Write("Введите массив: ");
string arrayString = Console.ReadLine().Trim(' '); //удалил пробелы, которые юзер мог поставить по ошибке
string [] arraySplit = arrayString.Split(',', ' ');
int [] arrayInt = new int [arraySplit.Length] ;
Console.Write("Введенный массив: ");
for (int i=0; i<arraySplit.Length; i++)
{
    arrayInt[i]=int.Parse(arraySplit[i]);
    Console.Write($" {arrayInt[i]}");    
}
Console.WriteLine();

int count=0;
for (int i=0; i<arrayInt.Length; i++)
{
    if (arrayInt[i]>0)
    {
        count++;
    }    
}

Console.WriteLine($"Количество положительных элементов в массиве array равно: {count}");