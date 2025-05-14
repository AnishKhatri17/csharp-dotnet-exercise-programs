using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            Console.WriteLine("\n\nThe natural numbers from 1 to 100 is : \n\n");
            for(i=1; i<=100; i++)
            {
                Console.WriteLine(i);
            }
                Console.ReadKey();
        }
    }
}
