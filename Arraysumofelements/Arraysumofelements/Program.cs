using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Arraysumofelements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum=0;
            int[] a = new int[20];
            Console.WriteLine("\n\nEnter the number of Array Elements :(1-20) ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEmter the Array Elements to find Sum : ");
            for(i=0; i<n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                
            }
                for(i=0; i<n; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("\nThe sum of the Array Elements are : " + sum);
            Console.ReadKey();
        }
    }
}
