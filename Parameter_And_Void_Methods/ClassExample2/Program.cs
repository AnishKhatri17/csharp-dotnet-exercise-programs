using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2
{
    public class Program
    {
        // Void ,Method that doesn't return a value ...
        public void Area()
        {
            int l, b, a;
            Console.Write("Enter the length (in meters) : ");
            l= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the breadth (in meters) : ");
            b = Convert.ToInt32(Console.ReadLine());
            a = l * b;
            Console.WriteLine("\n\nThe Area of a Rectangle is : "+a);
        }
        //Method with Parameters ...
            public int Volume(int l, int b, int h)
        {
            int Vol ;
            Vol = l * b * h ;
            Console.WriteLine("The Volume of A Rectangle is : " + Vol);
            return Vol;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Program p2 = new Program();
            p.Area();
            p2.Volume(10,10,10);
            Console.ReadKey();
        }
    }
}
