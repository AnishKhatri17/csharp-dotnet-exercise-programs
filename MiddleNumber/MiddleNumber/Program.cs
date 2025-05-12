using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c ;
            Console.WriteLine("Enter first Number :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third Number :");
            c = Convert.ToInt32(Console.ReadLine());

                if((a>b && a<c) || (a<b && a>c))
            {
                Console.WriteLine("Middle Number is : "  +a);
            }
                else if((b>c && b<a) || (b<c && b>a))
            {
                Console.WriteLine("Middle Number is : " +b);
            }
                else if((c>a && c<b) || (c<a && c>b))
            {
                Console.WriteLine("Middle Number is : "+ c);
            }
            else
            {
                Console.WriteLine("Case doesn't Match...");
            }
            Console.ReadKey();
        }
    }
}
