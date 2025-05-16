using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbyvalueGreatest
{
            public class Program
              {
        public void GreatestNumber(int first, int second, int third)
        {
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine("\n\nThe Greatest Number is : " + first);
                }
            }
                    else if(second > third)
            {
                if (second > first) 
                {
                    Console.WriteLine("\n\nThe Greatest Number is : " + second);
                }
            }
            else
            {
                Console.WriteLine("\n\nThe Greatest Number is : " + third);
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.GreatestNumber(10, 15, 70);
        }
    }
}
