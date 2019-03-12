using System;
class ConDemo
    {
        public ConDemo()
        {
            Console.WriteLine("Constructor is called");
        }
        public void Demo()
        {
            Console.WriteLine("Method is called");
        }
        static void Main()
        {
            ConDemo cd1 = new ConDemo();
            ConDemo cd2 = new ConDemo();
            ConDemo cd3 = cd1;
            cd1.Demo();
            cd2.Demo();
            cd3.Demo();
            Console.ReadLine();
        }
    }