using System;
interface Interface1
    {
        void Test();
        void Show();
    }
interface Interface2
    {
        void Test();
        void Show();
    }
class Interclass: Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("Declare under both interface");
        }
        void Interface1.Show()
        {
            Console.WriteLine("Declare in 1st interface");
        }
        void Interface2.Show()
        {
            Console.WriteLine("Declare in 2st interface");
        }
        static void Main()
        {
            Interclass c = new Interclass();
            c.Test();
            Interface1 i1 = c;
            Interface2 i2 = c;
            i1.Show();
            i2.Show();
            Console.ReadLine();
        }
    }