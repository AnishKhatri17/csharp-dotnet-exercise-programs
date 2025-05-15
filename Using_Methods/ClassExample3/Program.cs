using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample3
{
    internal class Mathematics
    {
        int a, b ;
        public void add()
        {
            int c;
            c = a + b;
            Console.WriteLine("The Sum of two numbers is " + c);
        }
        public void subtract()
        {
            int c;
            c = a - b;
            Console.WriteLine("The Difference of two numbers is " + c);
        }
        public int multiply()
        {
            int c;
            c = a * b;
            Console.WriteLine("The Multiply of two numbers is " + c);
            return c;
        }
        public int division()
        {
            int c;
            c = a / b;
            Console.WriteLine("The Division of two numbers is " + c);
            return c;
        }
        static void Main(string[] args)
        {
            Mathematics obj = new Mathematics();
            Mathematics obj2 = new Mathematics();
           // Mathematics obj3 = new Mathematics();
            obj.a = 20;
            obj.b = 10;
            obj.add();
            obj.subtract();
            obj.multiply();
            obj.division();

            Console.WriteLine("\n\n");
            obj2.a = 50;
            obj2.b = 5;
            obj2.add();
            obj2.subtract();
            obj2.multiply();
            obj2.division();


            Console.ReadKey();
        }
    }
}
