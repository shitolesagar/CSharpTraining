using System;
class StaticMets
    {
        int x = 100;
        static int y = 200;
        public static void Add()
        {
            StaticMets obj = new StaticMets();
            Console.WriteLine(obj.x + y);
        }

        static void Main()
        {
            StaticMets.Add();
            Console.ReadLine();
        }
    }