using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    internal class Anish
    {
        public int Biggest(int x, int y)
        {
            int result;
            if(x>y) 
            {
                result = x;
            }
            else 
            {
                result = y;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Anish a1 = new Anish();
            int first = 50;
            int second = 45;
            int output = a1.Biggest(first, second);
           Console.WriteLine("The biggest number is : \n"+output);

            Console.ReadKey();
        }
    }
}
