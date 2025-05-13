using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i =1 ;
            Console.WriteLine("The natural numbers from 1 to 100 ");
            
                while(i <=100)
            {
                Console.WriteLine(i);
                
                i++;
            }
            Console.ReadKey();
        }
    }
}
