using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallofvalueVolume
{
    public class Vol
    {
            public void volume(int l, int b, int h)
        {
            int result;
            result = l * b * h;
            Console.WriteLine("\n\n\nThe volume of the First Rectangle is : " +result);
           // Console.WriteLine("\n\nThe volume of the First Rectangle is : " + result);
           // Console.WriteLine("\n\nThe volume of the First Rectangle is : " + result);
        }
        static void Main(string[] args)
        {
            Vol v1 = new Vol();
            Vol v2 = new Vol();
            Vol v3 = new Vol();
            v1.volume(10, 20, 30);
            v2.volume(5, 20, 50);
            v3.volume(11, 25, 60);
            Console.ReadKey();
        }
    }
}
