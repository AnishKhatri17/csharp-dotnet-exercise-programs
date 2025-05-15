using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, r;
            Console.Write("Enter the number you want multiplication tables for: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine($"Multiplication Table of {i}:");
                for (j = 1; j <= 10; j++)
                {
                    r = i * j;
                    Console.WriteLine($"{i} x {j} = {r}");
                }
                Console.WriteLine(); // Blank line after each table
            }

            Console.ReadKey();
        }
    }
}

