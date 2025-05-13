using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DMatrixTranspose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, m, n ;
            int[,] a = new int[10, 10];
            Console.WriteLine("\nEnter the rows and column of Matrix A.(1-5) : ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the Elements of matrix A: ");
            for (i=0; i<m; i++)
            {
                for(j=0; j<n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                    
            }
            Console.WriteLine("\n\nElements of Matrix Are : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i,j]);
                    Console.Write("\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n\nThe Transposed Matrix is : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[j, i]);
                   Console.Write("\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
