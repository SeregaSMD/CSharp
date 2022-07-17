//Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
string[] Words(string[] alf, int size)
{
    if (size == 0)
    {
        string[] result = new string[1];
        result[0] = "";
        return result;
    }
    else if (size > 0)
    {
        string[] temp = Words(alf, size - 1);
        string[] result = new string[temp.Length * alf.Length];
        int index = 0;
        for (int i = 0; i < temp.Length; i++)
        {
            for (int j = 0; j < alf.Length; j++)
            {
                result[index] = temp[i] + alf[j];
                index++;
            }
        }
        return result;
    }
    else
    {
        string[] result = new string[1];
        result[0] = "ошибка";
        return result;
    }

}

/* Console.Write("Введите допустимые символы алфавита: ");
string letters = Console.ReadLine(); */
string[] alf = { "а", "с", "и", "в" };
Console.Write("Введите длину слова: ");
int size = int.Parse(Console.ReadLine());

string[] result = Words(alf, size);
for (int i = 0; i < result.Length; i++)
{
    Console.Write(i + " " + result[i] + " ");
}