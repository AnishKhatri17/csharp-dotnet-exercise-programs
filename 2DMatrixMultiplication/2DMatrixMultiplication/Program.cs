using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DMatrixMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, m, n, p, q;
            int[,] a = new int[10, 10];
            int[,] b = new int[10, 10];
            int[,] c = new int[10, 10];
            Console.WriteLine("\nEnter the no. of Rows and Column of First Matrix(1-10) : ");
            m = Convert.ToInt32(Console.ReadLine());    
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the no. of Rows and Column of Second Matrix(1-10) : ");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());
                if(m == q || n == p) 
            {
                Console.WriteLine("\nEnter the elements of First Matrix : ");
                for(i = 0; i < m; i++)
                {
                    for(j = 0; j < n; j++)
                    {
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\t");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("\nEnter the elements of Second Matrix : ");
                for (i = 0; i < p; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        b[i, j] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\t");
                    }
                    Console.Write("\n");
                }
                /* Multiplication Starts From Here....................*/
                    for(i = 0; i < m; i++)
                {
                        for(j=0; j < q; j++)
                    {
                            c[i, j] = 0;
                            for(k=0; k < n; k++)
                        {
                            c[i, j] = c[i, j] + a[i, k] * b[k,j];
                        }
                    }
                }
                    
                    Console.WriteLine("\nThe Multiplied Resultant Matrix is : ");
                    for(i=0; i<m; i++)
                {
                        for(j=0; j<q; j++)
                    {
                        Console.WriteLine(c[i, j]);
                        Console.Write("\t");
                    }
                    Console.Write("\n");
                }
            }

            else
            {
                Console.WriteLine("\n\nError !!!! The Matrix can't be Multiplied .............");
            }
                Console.ReadKey();  
            
        }
    }
}
