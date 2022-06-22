// // Метод 1 типа
// void Method1()
// {
//     Console.WriteLine("Author is..");
// }
// // Вызов метода 1:
//Method1 ();

// Метод 2 типа
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Вызов метода 2:
// Method2 (msg:"Msg text");
// Метод 2 типа v2
// void Method2(string msg, int count)
// {
//     int i = 0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }

// }
// // Вызов метода 2 v2:
// Method2 ("Msg text", 2);
// // Вызов метода 2 v2:
// Method2 (count: 2, msg:"Msg text");

// // Метод 3 типа
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// // Вызов метода 3:
// int year = Method3();
// Console.WriteLine(year);

// Метод 4 типа
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// // Вызов метода 4:
// string res = Method4(10, "z");
// Console.WriteLine(res);

// //Метод 4 типа
// string Method4(int count, string text)
// {  
//     string result = String.Empty;
//     for (int i=0; i < count; i++)
//     {
//         result = result + text;        
//     }
//     return result;
// }
// // Вызов метода 4:
// string res = Method4(10, "z");
// Console.WriteLine(res);

// Таблица умножения
// void ProdTable()
// {  
//     string result = String.Empty;
//     for (int i=2; i <= 10; i++)
//     {
//         for (int j=2; j <= 10; j++)
//         {
//             Console.WriteLine($"{i} x {j} = {i*j}");
//         }
//         Console.WriteLine();
//     }    
// }
// ProdTable();

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int lenght = text.Length;
//     for (int i=0; i < lenght; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string text = "This is a test text.";
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// newText = Replace(newText, 't', 'T');
// Console.WriteLine(newText);
// newText = Replace(newText, 'T', 'p');
// Console.WriteLine(newText);

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int[] Swap(int idx1, int idx2, int[] array)
{
    int tmpval = array[idx1];
    array[idx1] = array[idx2];
    array[idx2] = tmpval;
    return array;
}

void SelectionSort(int[] array)
{
    
    for (int i = 0; i < array.Length-1; i++)
    {        
        int minidx = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minidx]) minidx = j;                        
        }
        Swap(i, minidx, array);
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);