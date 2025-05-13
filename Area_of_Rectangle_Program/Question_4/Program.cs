using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, b, a;
            Console.WriteLine("Enter length");
            l= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            b= Convert.ToInt32(Console.ReadLine());
            a = l * b;
            Console.WriteLine("Area of Rectangle is : "+a);
            Console.ReadKey();
        }
    }
}
