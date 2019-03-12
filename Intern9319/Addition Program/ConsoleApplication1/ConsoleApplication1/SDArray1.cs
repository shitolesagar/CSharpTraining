using System;
class SDArray1
{
    static void Main()
    {
        int[] arr = new int[6];
        int x = 10;
        for (int i = 0; i < 6; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
        for (int i = 0; i < 6; i++)
        {
            x += 5;
            arr[i] = x;
        }
        foreach (int i in arr)
            Console.Write(i + " ");
        Console.ReadLine();
    }
}
