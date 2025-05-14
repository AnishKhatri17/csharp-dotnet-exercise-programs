using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];
             arr[0] = "Anish";
             arr[1] = "Archana";
             arr[2] = "Shirish";
             arr[3] = "Junel";
             arr[4] = "Bitisha";
          
                foreach(string day in arr)
            {
                Console.WriteLine(day);
            }
                    Console.ReadKey();  
        }
    }
}
