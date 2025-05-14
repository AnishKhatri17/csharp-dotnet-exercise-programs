using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
       public class Program
    {
        int a, b, c;
        public void add()
        {
            c = a + b;
            Console.WriteLine("The sum of two numbers is :" + c);
           
        }
            public void subtract()
        {
            c = a - b;
            Console.WriteLine("\nThe difference of two numbers is :" + c);
        }
        static void Main(string[] args)
        {
            Program a1 = new Program();
            Program a2 = new Program();
            a1.a= 20;
            a1.b = 30;
            a1.add();
            a2.a = 50;
            a2.b = 10;
            a2.add();
            Console.ReadKey();
        }
    }
}
 