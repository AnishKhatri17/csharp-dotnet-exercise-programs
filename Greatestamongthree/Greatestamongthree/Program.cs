using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatestamongthree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter the value of First Number :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of Second Number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of Third Number :");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                //Console.WriteLine("The Greatest Number is = " + a);
                if (a > c)
                {
                    Console.WriteLine("The Greatest Number is = " + a);
                }
                else
                {
                    Console.WriteLine("The Greatest Number is = " + c);
                }
            }
            else
            {
                if (b > c)
                    Console.WriteLine("The Greatest number is = " + b);

                else
                {
                    Console.WriteLine("The Greatest number is = " + c);
                }
            }
            Console.ReadKey();
        }
    }
}
