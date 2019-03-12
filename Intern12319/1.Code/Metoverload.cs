using System;
class LoadDemo
    {
            public void show()
            {
                Console.WriteLine(1);
            }
            public void show(string s)
            {
                Console.WriteLine(s);
            }
            public void show(int x)
            {
                Console.WriteLine(x);
            }
            public void show(string s, int x)
            {
                Console.WriteLine(s+" "+x);
            }
            public void show(int x, string s)
            {
                Console.WriteLine(x+" "+s);
            }
            static void Main()
            {
                LoadDemo d = new LoadDemo();
                d.show();
                d.show(10);
                d.show("show");
                d.show(10, "hello");
                d.show("hell0", 10);

            }
        }