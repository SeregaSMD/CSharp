string[] Words (string [] alf, int number)
{
    if(number==0)
    {
        string[] result = new string [1];
        result[0]="";
        return result;
    };
    
    string[]temp=Words (alf, number-1);
    string [] result =new string [temp.Length*alf.Length];
    int index=0;
return result;
    
    string [] temp = Words (alf,number-1);
    string [] = new string [temp.Length*alf.Length]
    return Words(alf, number)+
}

string [] alf = {"а", "с", "и", "в"};
Console.WriteLine("Введите N");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();
string [] result = Words (alf, number);
for (int i=0;i<result[i]; i++)
{
    Console.WriteLine(result[i] + " ");
}
