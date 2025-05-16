using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimentionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] a = new int[3, 2]
            {
                {1,2}, 
                {1,2}, 
                {1,2}
            };


            Console.WriteLine("\n\nThe elements in the two dimentional Array are : \n");
                for(i=0; i<3; i++) 
            {
                for(j=0; j<2; j++)
                {
                    Console.Write(+a[i,j]);  
                    Console.Write("\t");
                }
                Console.WriteLine("\n");    
            }    
                Console.ReadKey();  
        }
    }
}
