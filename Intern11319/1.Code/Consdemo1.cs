using System;
class Math
    {
        int x=5, y;
        public Math(int x, int y)
        {   
            Console.WriteLine(this.x);
            this.x = x;
            this.y = y;
            Console.WriteLine(this.x);
        }
        public void Add()
        {
            Console.WriteLine(x + y);
        }
        public void Sub()
        {
            Console.WriteLine(x - y);
        }
        public void Mul()
        {
            Console.WriteLine(x * y);
        }
        public void Div()
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            Math m1=new Math(1,2);
            m1.Add();
            m1.Sub();
            m1.Mul();
            m1.Div();
            Console.ReadLine();
        }
    }