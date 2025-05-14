using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGreatestAndSmallest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, greatest, smallest ;
            int[] arr = new int[20];
            Console.Write("\nEnter the number of Array Elements(1-20) : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the Array Elememts : ");
                for(i = 0; i < n; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            greatest = arr[0];
            smallest = arr[0];
                for(i = 0; i < n; i++)
            {
                if (greatest < arr[i])
                {
                    greatest = arr[i];
                }
                    if(smallest > arr[i])
                {
                    smallest = arr[i];
                }

            }
            Console.WriteLine("\n\nThe Greatest Number of an Array is : " + greatest);
            Console.WriteLine("The Smallest Number of an Array is : " + smallest);
            Console.ReadKey();
        }
    }
}
