using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestAmong4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Enter first Number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second Number:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third Number:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter fourth Number:");
            d = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    if (a > d)
                    {
                        Console.WriteLine("The biggest value is: " + a);
                    }
                    else
                    {
                        Console.WriteLine("The biggest value is: " + d);
                    }
                }
                else
                {
                    if (c > d)
                    {
                        Console.WriteLine("The biggest value is: " + c);
                    }
                    else
                    {
                        Console.WriteLine("The biggest value is: " + d);
                    }
                }
            }
            else
            {
                if (b > c)
                {
                    if (b > d)
                    {
                        Console.WriteLine("The biggest value is: " + b);
                    }
                    else
                    {
                        Console.WriteLine("The biggest value is: " + d);
                    }
                }
                else
                {
                    if (c > d)
                    {
                        Console.WriteLine("The biggest value is: " + c);
                    }
                    else
                    {
                        Console.WriteLine("The biggest value is: " + d);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
