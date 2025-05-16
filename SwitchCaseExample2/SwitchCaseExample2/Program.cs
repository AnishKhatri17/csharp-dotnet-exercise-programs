using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, d;
            float e;
            char x;
            Console.Write("\nEnter the value of First Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the value of Second Number : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nEnter the symbol of operation you wanna perform : "+
                "\nType + for Addition. \nType - for Subtraction. \nType * for Multiplication. \nType / for division. \n\nEnter : ");
            x = Convert.ToChar(Console.ReadLine());
            switch (x)
            {
                case '+':
                    {
                        d = a + b;
                        Console.WriteLine("\n\nThe sum of two numbers is : "+d);
                        break;
                    }
                case '-':
                    {
                        d = a - b;
                        Console.WriteLine("\n\nThe difference of two numbers is : " + d);
                        break;
                    }
                case '*':
                    {
                        d = a * b;
                        Console.WriteLine("\n\nThe multiplication of two numbers is : " + d);
                        break;
                    }
                case '/':
                    {
                        e = a / b;
                        Console.WriteLine("\n\nThe division of two numbers is : " + e);
                        break;
                    }
                default : 
                    {
                        Console.WriteLine("\n\nInvalid Choice !!!!! \nPlease Try Again.");
                        break;
                    }
            }
                    Console.ReadKey();  
        }
    }
}
