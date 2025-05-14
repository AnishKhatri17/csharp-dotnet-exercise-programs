using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest_Among_Two_using_class_object
{
    internal class Biggest
    {
       int x, y;
       
        public void Greatest()
        {
            Console.WriteLine("Enter First Number.");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number.");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("The biggest number is : "+x);
            }
            else
            {
                Console.WriteLine("\nThe biggest number is : " +y);
            }
        }
        static void Main(string[] args)
        {
            Biggest big = new Biggest();
           // big.x = 100;
           // big.y = 150;
            big.Greatest();
            Console.ReadKey();
        }
    }
}
