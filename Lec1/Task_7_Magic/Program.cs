﻿Console.Clear();
int xa =40, ya = 1, xb = 1, yb=30, xc =80, yc=30;
Console.SetCursorPosition (xa,ya);
Console.WriteLine("+");
Console.SetCursorPosition (xb,yb);
Console.WriteLine("+");
Console.SetCursorPosition (xc,yc);
Console.WriteLine("+");

int count=0;
int x=xa, y=ya;

while (count<10000)
{
    int rand=new Random().Next(0,3);
    if (rand==0)
    {
        x=(x+xa)/2;
        y=(y+ya)/2;
    }
    if (rand==1)
    {
        x=(x+xb)/2;
        y=(y+yb)/2;
    }
    if (rand==2)
    {
        x=(x+xc)/2;
        y=(y+yc)/2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}
Console.SetCursorPosition(1,30);