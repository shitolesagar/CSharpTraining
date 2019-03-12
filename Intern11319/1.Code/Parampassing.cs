
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        
        public void Test1() //satatic action
        {
            int n = 5;
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
        }
        
        public void Test2(int n, int m)//dynamic action
        {

            for (int i = 1; i <= m; i++)
                Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
        }
        
        public string Test3()//static action
        {
            string str = "Sagar";
            str = str.ToUpper();
            return str;
        }
        
        public string Test4(string str)//dynamic action
        {
            str = str.ToUpper();
            return str;
        }

        static void Main(string[] args)
        {
            Program P = new Program();

            P.Test1();
            P.Test2(8, 10);
           
            string s1 = P.Test3();
            Console.WriteLine(s1);
            string s2 = P.Test4("shitole");
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}

