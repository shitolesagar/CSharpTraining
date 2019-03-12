using System;
class Class1
    {
          public Class1()
            {
                Console.WriteLine("class1 constructor is called");
            }
            public void Test1()
            {
                Console.WriteLine("method 1");
            }
            public void Test2()
            {
                Console.WriteLine("method 2");
            }
        }
        class Class2: Class1
    {
        public Class2()
        {
            Console.WriteLine("Class2 constructor is called");
        }
         static void Main()
        {
        Class2 a=new Class2();
        
            a.Test1();
            a.Test2();
            Console.ReadLine();
        
        }
    }