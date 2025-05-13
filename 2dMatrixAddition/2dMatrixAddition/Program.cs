using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dMatrixAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, m, n, p, q;
            int[,] a = new int[10, 10];
            int[,] b = new int[10, 10];
            int[,] c = new int[10, 10];
            Console.WriteLine("\nEnter the size of the First Matrix 'Row and Column' Max_(1-10) :  ");
            m = Convert.ToInt32(Console.ReadLine());   //Row of First Matrix
            n = Convert.ToInt32(Console.ReadLine());   //Column of First Matrix
            Console.WriteLine("\nEnter the size of the Second Matrix 'Row and Column' Max_(1-10) :  ");
            p = Convert.ToInt32(Console.ReadLine());   //Row of Second Matrix
            q = Convert.ToInt32(Console.ReadLine());   //Column of Second Matrix
                if(m==p && n==q)  //Comparing size of rows and column of first and second matrix respectively ...
            {
                Console.WriteLine("\nEnter the Elements of First Matrix : ");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        a[i,j] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\t"); 
                    }
                    Console.Write("\n");
                }
               
                Console.WriteLine("\nEnter the Elements of Second Matrix : ");
                for (i = 0; i < p; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        b[i, j] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\t");
                    }
                    Console.Write("\n");
                }
                /*Additionn Starts.... */
                for(i= 0; i < m; i++)
                {
                    for(j=0; j < q; j++)
                    {
                        c[i,j] = a[i,j] + b[i,j];
                        Console.Write("\t");    
                    }
                }
                Console.WriteLine("\nThe resultant Matrix is : " );
                for(i = 0; i < m; i++)
                {
                    for(j=0; j<q; j++)
                    {
                        Console.Write(c[i,j]);
                        Console.Write("\t");
                    }
                    Console.WriteLine("\n");
                }
                     
            }
            else
            {
                Console.WriteLine("\n\n The no. of Rows or Column of First Matrix is not equal to Second Matrix .Error !!!!!!!!!!!!!!!");
            }
            Console.ReadKey();
        }
    }
}
