using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Feb_Challenges_Give_on_Friday_23rd_Feb_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an interger greater than 1:");
            int x = 0;
            int product = 1;
            int factor = 0;
            int n = 0;
            while (product < x) ;
            {
                factor = factor++;
                product = product * factor;
            }
            if (x == product)
            {
                product = 1;
                for (n = 1; n <= factor; n++) ;
                {
                    product = product * n;
                    Console.Write(n);
                }

            }
            Console.WriteLine("No Result");
            Console.ReadLine();
        }
    }
}
