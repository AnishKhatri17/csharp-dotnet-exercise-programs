using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInAscendingOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, temp = 0;
            int[] arr = new int[20];
            Console.Write("\nEnter the no. of Array Elements you want to sort in Ascending Order : ");
            n = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Enter the Array Elements : ");
            for(i=0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }
                for(i=0; i<n; i++)
            {
                for(j=i+1; j<n; j++) 
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n\nArray Elements in Ascending order is : ");
            for (i=0; i<n;i++) 
            {
                Console.WriteLine(+arr[i]);
            } 
            Console.ReadKey();
        }
    }
}
