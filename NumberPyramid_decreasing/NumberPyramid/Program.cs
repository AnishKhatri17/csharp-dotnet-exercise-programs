using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, num;
            Console.WriteLine("\nEnter the number to see the pyramid : ");
            num = Convert.ToInt32(Console.ReadLine());
                for(i=num; i>=1; i--) 
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j +"\t");
                }
                Console.WriteLine("\n");
            }
                Console.ReadKey();
        }
    }
}
