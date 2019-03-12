using System;
class Matrix
    {
        int a, b, c, d;
        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;this.b = b;this.c=c;this.d=d;
        }

        public static Matrix operator +(Matrix m1,Matrix m2)
        {
            Matrix obj = new Matrix(m1.a + m2.a, m1.b + m2.b,m1.c + m2.c, m1.d + m2.d);
            return obj;
        }


        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix obj = new Matrix(m1.a - m2.a, m1.b - m2.b, m1.c - m2.c, m1.d - m2.d);
            return obj;
        }
        public override string ToString()
        {
            return a+ " "+ b + "\n" + c + " " + d +"\n";
        }
    }

    class TestMatrix
    {
        static void Main()
        {
            
            Matrix m1 = new Matrix(18, 16, 14, 12);
            Matrix m2 = new Matrix(10, 8, 6, 4);
            Matrix m3 = new Matrix(4, 3, 2, 1);

            
            Matrix m4 = (m1 + m2) + m3;
            Matrix m5 = (m1 - m2) - m3;
            
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.WriteLine(m5);
            Console.ReadLine();            
        }
    }