using System;
class StaticVars
    {
        int x;
        static int y = 200;
        const float pi = 3.14f;
        readonly bool flag;
        public StaticVars(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
        static void Main()
        {
            Console.WriteLine(y);
            Console.WriteLine(pi);
            StaticVars s1 = new StaticVars(50, true);
            StaticVars s2 = new StaticVars(150, false);
            Console.WriteLine(s1.x + " " + s2.x);
            Console.WriteLine(s1.flag + " " + s2.flag);
            Console.ReadLine();
       }

    }