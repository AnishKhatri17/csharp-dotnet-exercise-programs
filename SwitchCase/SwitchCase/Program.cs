using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("\nEnter your choice from 1 - 7 to select day of the week : ");
            day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                
                case 1:
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Today is Sunday.");
                        break;
                    }
                case 2: 
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Today is Monday.");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Today is Tuesday.");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Today is Wednesday.");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Today is Thursday.");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Today is Friday.");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Today is Saturday.");
                        break;
                    }
                default :
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Invalid Choice !!!!!!");
                         break;
                    }

            }
            Console.ReadKey();
        }
    }
}
