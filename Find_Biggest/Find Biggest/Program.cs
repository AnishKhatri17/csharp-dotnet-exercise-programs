using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Biggest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first, second;
            Console.WriteLine("Enter the value of First Number and Second Number : ");
            Console.WriteLine("\n\n");
            first = Convert.ToInt32(Console.ReadLine());
            second = Convert.ToInt32(Console.ReadLine());
                if (first > second)
            {
                Console.WriteLine("The greatest number is = " + first);
            }
                else
            {
                Console.WriteLine("The greatest number is = " + second);
            }
                Console.ReadKey();
        }
    }
}
