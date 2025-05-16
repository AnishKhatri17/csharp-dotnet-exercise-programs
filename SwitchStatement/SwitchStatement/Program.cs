using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
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
                        Console.WriteLine("Today is Sunday. Click Enter to Exit");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Today is Monday. Click Enter to Exit");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Today is Tuesday. Click Enter to Exit");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Today is Wednesday. Click Enter to Exit");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Today is Thursday. Click Enter to Exit");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Today is Friday. Click Enter to Exit");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Today is Saturday. Click Enter to Exit");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Invalid Choice !!!!!!");
                        break;
                    }  

            }
            Console.ReadLine();
        }
    }
}
