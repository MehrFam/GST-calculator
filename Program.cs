using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GST_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gstValue = 0.15;
            double gstReminder = (3.0 / 23.0);

            Console.WriteLine("Enter the product name:");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter Quantity:");
            int prductQty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Cost:");
            decimal productCost = Convert.ToDecimal(Console.ReadLine());

            bool isGstincluded;

            Console.WriteLine("Does it include GST (y/n)?");
            string includeGst = Console.ReadLine();
            if(includeGst == "y") 
            {
                isGstincluded = true;

            } else
            {
                isGstincluded = false;
            }

            decimal cost = productCost * prductQty;

            if (isGstincluded)
            {
                decimal totalCost = cost + (cost * Convert.ToDecimal(gstValue));
                Console.WriteLine("Total Cost + GST: " + totalCost);
            }
            else
            {
                decimal gstPrice = cost * Convert.ToDecimal(gstReminder);
                decimal totalCost = cost - gstPrice;
                Console.WriteLine("Total cost - GST:" );
            }
            Console.ReadKey();
        }
    }
}
