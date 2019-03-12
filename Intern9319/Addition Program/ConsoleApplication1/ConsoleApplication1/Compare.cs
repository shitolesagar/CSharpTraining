using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class Compare
    {
        static void Main()
        {
            Console.Write("Enter the value");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter another value");
            int y = int.Parse(Console.ReadLine());

            if (x > y)
                Console.WriteLine(x+ " is greater");
            else if (y > x)
                Console.WriteLine(y+ " is greater");
            Console.ReadLine();
        }

    }
}
