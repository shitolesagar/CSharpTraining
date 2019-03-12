using System;
class SDArray2
{
    static void Main()
    {
        Console.WriteLine("Original Array is:\n");
        int[] arr = { 33, 56, 34, 22, 78, 92, 56, 78, 94, 55 };
        for (int k = 0; k < arr.Length; k++) 
        Console.Write(arr[k] + " ");
        Console.WriteLine("\n");
        Array.Sort(arr); 	
        Console.WriteLine("Sorted Array is:\n");
        foreach (int i in arr)
            Console.Write(i + " ");
        Console.WriteLine("\n");
        Array.Reverse(arr);
        Console.WriteLine("Reverse Array is:\n");
        foreach (int i in arr)
            Console.Write(i + " ");
        Console.WriteLine("\n");
        int[] brr = new int[10];
        Array.Copy(arr, brr, 5);
        Console.WriteLine("brr Array is:\n");
        foreach (int i in brr)
            Console.Write(i + " ");
        Console.WriteLine("\n");
        Console.ReadLine();
    }
}
