using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Array_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum =0;
            int[] a = new int[10];
            Console.WriteLine("\nEnter the no. of Array Elements (1-10) : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the Array Elements : ");
                for(i = 0; i < n; i++) 
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
           // Console.WriteLine("\n\nThe Array Elements Are : \n");

                 for(i = 0; i < n;i++)
            {
                sum = sum + a[i];   
            }
            Console.WriteLine("\n\nThe sum of the Array Elements is : "+sum);
            Console.ReadKey();
        }
    }
}
