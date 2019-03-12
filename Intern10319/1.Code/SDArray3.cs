using System;
class SDArray3
{
static void Main()
{
var iarr=new[] {10,20,30,40,50};
foreach(int i in iarr)
Console.Write(i+" ");
Console.WriteLine();
var sarr= new[] {"Red", "Pink", "Blue", "White","\n"};
foreach(String color in sarr)
Console.Write(color + " ");
}
}
