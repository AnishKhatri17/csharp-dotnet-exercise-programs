using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, b, a;
            Console.WriteLine("Enter the length of rectangle : ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breadth of rectangle : ");
            b = Convert.ToInt32(Console.ReadLine());
            a = l * b;
            Console.WriteLine("The area of a rectangle is = "+a);
        }
    }
}
