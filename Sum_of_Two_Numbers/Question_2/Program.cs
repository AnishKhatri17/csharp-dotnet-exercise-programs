using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the value of first number.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of second number.");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("The sum of two numbers is :"+c);

            Console.ReadKey();

        }
    }
}
