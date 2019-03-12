using System;
class TDArray
{
static void Main()
{
int[,] arr = new int [4,5];
int x=0;

foreach(int i in arr)
Console.Write(i+"");
Console.WriteLine();
 
for( int i=0; i< arr.GetLength(0);i++)
{
 for(int j=0; j< arr.GetLength(1);j++)
{
x+=5;
arr[i,j]=x;
}
}

for( int i=0; i< arr.GetLength(0);i++)
{
 for(int j=0; j< arr.GetLength(1);j++)
{
Console.Write(arr[i, j]+" ");
Console.WriteLine();
}
}
}
}