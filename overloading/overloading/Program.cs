using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    internal class Program
    {
        void display(int a)
        {
            Console.WriteLine("the value of a is: " + a);
        }

        void display(int a,int b)
        {
            Console.WriteLine("the value of a is:" + a+ "\n" + "the value of b is: "+b);
                }
        static void Main(string[] args)
        {
            // Example of Method Overloading in C# .....
            Program obj = new Program();
            obj.display(1);
            obj.display(50, 60);
            obj.display(55, 100);
            Console.ReadLine();
        }
    }
}
