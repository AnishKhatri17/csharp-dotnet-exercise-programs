using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14, r, a;
            Console.WriteLine("Enter the radius of a Circle :");
            r = Convert.ToDouble(Console.ReadLine());
            a = pi * r * r;
            Console.WriteLine("The area of a circle is = " + a);
            Console.ReadKey();
        }
    }
}
