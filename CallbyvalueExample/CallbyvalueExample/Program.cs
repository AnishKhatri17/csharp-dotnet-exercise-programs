using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbyvalueExample
{
    public class Program
    {
            static void callbyvalue(int a)
        {
            Console.Write("The value of a is :"+a);
        }
        static void Main(string[] args)
        {
            callbyvalue(25);
            Console.ReadKey();
        }
    }
}
