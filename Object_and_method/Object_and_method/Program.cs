using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_and_method
{
    internal class Calculator
    {
        int n1;
        int n2;
        int result;

            void add()
        {
            result = n1 + n2;
            Console.WriteLine("The sum of two numbers is :" +result+"\n");
          //  Console.ReadLine(); 
        }

        void sub()
        {
            result = n1 - n2;
            Console.WriteLine("The difference of two numbers is :" + result+"\n");
            //Console.ReadLine();
        }

        void mul()
        {
            result = n1 * n2;
            Console.WriteLine("The product of two numbers is :" + result + "\n");
           // Console.ReadLine();
        }
        
            static void Main(string[] args)
            {
                Calculator obj = new Calculator();
                obj.n1 = 55;
                obj.n2 = 11;
                obj.add();
                obj.sub();
                obj.mul();
                Console.ReadKey();
            }
        
    }
}
