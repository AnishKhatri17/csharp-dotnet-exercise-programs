using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] a = new int[100];
            Console.WriteLine("Enter the no. of Array Elements :(1-100) ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Elements of an Array : ");
            for (i=0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine()); 
               
            }
            Console.WriteLine("\n\nThe Array Elements Are : ");
                for(i=0; i < n; i++)
            {
                Console.Write(" \n" + a[i]);
            }
                Console.ReadKey();  
        }

    }
}
