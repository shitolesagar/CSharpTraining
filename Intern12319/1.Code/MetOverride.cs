using System;
class LoadParent
    {
        public void Test()
        {
            Console.WriteLine("Parents test method");
        }
        public virtual void Show()  //overridable
        {
            Console.WriteLine("Parents SHOW Method");
        }
        public void Display()
        {
            Console.WriteLine("Parents display Method");
        }
    }
    class LoadChild : LoadParent
    {
        //overloading parent Test under child
        public void Test(int x)
        {
            Console.WriteLine("Childs test method");
        }
        static void Main()
        {
            LoadChild c = new LoadChild();
            c.Test();       //executes parents Test method
            c.Test(10);     //executes childs Test method
            c.Show();       //executes parents Show method
            c.Display();    //executes parents Display method
            Console.ReadLine();
        }

    }