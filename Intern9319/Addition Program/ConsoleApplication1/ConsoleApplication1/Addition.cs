using System;
class AddNums3
{
    static void Main()
    {
        Console.Write("Enter first number");
        string n1 = Console.ReadLine();
        Console.Write("Enter Second Number");
        string n2 = Console.ReadLine();
        int i1 = int.Parse(n1);
        int i2 = int.Parse(n2);
        int z = i1 + i2;
        Console.WriteLine("Addition of {0} and {1} is {2} ", n1, n2, z);
        Console.ReadLine();
    }
}
