using System;
class LoadCon
    {
        int x;
        public LoadCon()    //default constructor
        {
            this.x = 40;
        }
        public LoadCon(int x)
        {
            this.x = x;
        }
        public void Display()
        {
            Console.WriteLine("the value of x is : {0}", x);
        }
        static void Main()
        {
            LoadCon c1 = new LoadCon();
            LoadCon c2 = new LoadCon(100);
            c1.Display();
            c2.Display();
            Console.ReadLine();
        }
    }