using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Constructor
    {
        int a=5 , b=8; 
         Constructor()
        {
            int c = a + b;
            Console.WriteLine("The sum is : "+c);
            Console.WriteLine("HELLOOOOOOOOOOOO");
        }//default Constructor


     
        static void Main(string[] args)
        {
        Constructor c = new Constructor();

            //c.Constructor();
            Console.ReadKey();
        }
    }
}
