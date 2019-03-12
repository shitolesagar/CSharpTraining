using System;
class SwitchDemo
{
    static void Main()
    {
        Console.Write("Enter your choise\n1-student1\n2-student2\n3-student3\n");
        int sno = int.Parse(Console.ReadLine());
        switch (sno)
        {
            case 1:
                Console.WriteLine("Student 1");
                Console.ReadLine();
                break;
            case 2:
                Console.WriteLine("Student 2");
                Console.ReadLine();
                break;
            case 3:
                Console.WriteLine("Student 3");
                Console.ReadLine();
                break;

            default:
                Console.WriteLine("Student");
                Console.ReadLine();
                break;
        }
    }
}
