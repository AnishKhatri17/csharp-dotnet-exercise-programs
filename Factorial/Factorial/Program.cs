using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, fact = 1, i;
            Console.Write("\n\nEnter the number you want the factorial of : ");
            n = Convert.ToInt32(Console.ReadLine());
                for(i=1; i<=n; i++)
            {
                fact = fact*i;
            }
            Console.WriteLine("\nThe factorial of a given number is = "+fact);
        }
    }
}
