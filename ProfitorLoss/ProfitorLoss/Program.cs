using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitorLoss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cost, sales, gain, loss;
            Console.WriteLine("Enter the Cost Price of the item : ");
            cost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Sales Price of the item : ");
            sales = Convert.ToInt32(Console.ReadLine());
            gain = sales - cost;
            loss = cost - sales;
                if(cost > sales)
            {
                Console.WriteLine("\n\nThere is a Loss of Rs."+loss);
            }
                else 
            {
                Console.WriteLine("\nThere is a Profit of Rs." +gain) ;
            }
            Console.ReadKey();
        }
    }
}
