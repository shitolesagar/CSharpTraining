using System;
class JaggedDemo
{
static void Main()
{
int [] [] arr = new int [4][];
arr[0]= new int[5];
arr[1]= new int[6];
arr[2]= new int[8];
arr[3]= new int[4];


for(int i=0;i<arr.GetLength(0);i++)
{
for(int j=0;j<arr[i].Length; j++)
{
Console.Write(arr[i][j] + " ");
Console.WriteLine();
}
}

for(int i=0;i<arr.GetLength(0);i++)
{
for(int j=0;j<arr[i].Length; j++)
{
arr[i][j]=j+1;
}
}
 
Console.WriteLine();
for(int i=0;i<arr.GetLength(0);i++)
{
foreach(int x in arr[i])
Console.Write(x + " ");
Console.WriteLine();
}
}
}