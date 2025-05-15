using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, product;
            Console.WriteLine("Enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            c = Convert.ToInt32(Console.ReadLine());
            product = a * b * c;
            Console.WriteLine("Product of three number is" + product);
            Console.ReadKey();
        }
    }
}
