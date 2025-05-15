using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultofStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CG, Network, MIS, Mgmt, dotnet, total;
            double percentage  ;
            Console.Write("Enter The marks obtained in Computer Graphis :");
            CG = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The marks obtained in Computer Network :");
            Network = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The marks obtained in MIS :");
            MIS = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The marks obtained in Management :");
            Mgmt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The marks obtained in .NET Technology :");
            dotnet = Convert.ToInt32(Console.ReadLine());
                    total = CG + Network + MIS + Mgmt + dotnet;  
                    percentage = total / 5;
            if(percentage >= 90)
            {
                Console.WriteLine("\n\nYou have obtained " + percentage + "%\tPercentage and the result is : A+");
            }
            else if (percentage >= 80 && percentage<90)
            {
                Console.WriteLine("\n\nYou have obtained " + percentage + "%\tPercentage and the result is : A");
            }
            else if (percentage >= 70 && percentage < 80)
            {
                Console.WriteLine("\n\nYou have obtained " + percentage + "%\tPercentage and the result is : B+");
            }
            else if (percentage >= 60 && percentage < 70)
            {
                Console.WriteLine("\n\nYou have obtained " + percentage + "%\tPercentage and the result is : B");
            }
            else if (percentage >= 50 && percentage < 60)
            {
                Console.WriteLine("\n\nYou have obtained " + percentage + "%\tPercentage and the result is : C+");
            }
            else if (percentage >= 40 && percentage < 50)
            {
                Console.WriteLine("\n\nYou have obtained " + percentage + "%\tPercentage and the result is : C");
            }
            else if (percentage >= 35 && percentage < 40)
            {
                Console.WriteLine("\n\nYou have obtained " + percentage + "%\tPercentage and the result is : D");
            }

            else 
            {
                Console.WriteLine("\n\nYou have obtained " + percentage + "\twhich is not sufficient and you Failed.");
            }
                    Console.ReadKey();
        }
    }
}
