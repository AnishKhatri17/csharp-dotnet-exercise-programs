using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInDescendingOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, temp = 0;
            int[] a = new int[20];
            Console.Write("\nEnter the no. of Array Elements you want in Descending Order : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter The Array Elements : ");
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

                for(i = 0; i < n;i++) 
            {
                      for(j=i+1; j<n; j++) 
                {
                    if (a[i] < a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n\nArray Elements in Desccending Order is : ");
            for(i = 0; i < n; i++) 
            {
                Console.Write(a[i]+ "\t");
            }
            Console.ReadKey();
        }
    }
}
