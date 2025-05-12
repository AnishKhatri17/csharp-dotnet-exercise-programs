using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_statement
{
    internal class Anish
    {
        static void Main(string[] args)
        {
            int i;
            for(i=1; i<=10; i++)
            {
                if (i == 7)
                    break;
                Console.WriteLine(i);
                //i++;
            }
            Console.WriteLine("Loop is Terminated.");
            Console.ReadKey();
        }
    }
}
