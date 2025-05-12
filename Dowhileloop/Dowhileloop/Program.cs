using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dowhileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=1, num, sum=0;
            Console.WriteLine("\n\nEnter the number you wanna print even numbers of : ");
            num = Convert.ToInt32(Console.ReadLine());  
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("The even number is : "+i );
                    sum = sum + i;
                }
                
                i++;
            } while (i <= num);
            Console.WriteLine("\n\nThe Sum is :" +sum);

            Console.WriteLine("End of the loop............");
            Console.ReadKey();
        }
    }
}
