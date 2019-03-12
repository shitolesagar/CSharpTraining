using System;
class Return 
{
static void Main()
{
Console.WriteLine("Enter integer value");
int x=int.Parse( Console.ReadLine());
if(x==0)
return;
for(int i=0;i<100;i++)
{
Console.WriteLine("{0}*{1}={2}",x ,i ,x*i);
}
    Console.ReadLine();
}
}
