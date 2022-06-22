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

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i=0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string text = "This is a test text.";
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
newText = Replace(newText, 't', 'T');
Console.WriteLine(newText);
newText = Replace(newText, 'T', 'p');
Console.WriteLine(newText);