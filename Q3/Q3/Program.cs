using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------ this program will expand a basic quadratic equation ---------------------------------");
            Console.WriteLine("---------------------------------------------  (x + n) (x + m)  ----------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Looking at the above brackets...... ");

            Console.WriteLine("enter a +ve or a -ve value for n: ");
            decimal n = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter a +ve or a -ve value for m: ");
            decimal m = decimal.Parse(Console.ReadLine());
            decimal b = n + m;
            decimal c = n * m;
            
            Console.WriteLine("That in standard form is: x^2 {0}x {1} ",b,c);

            Console.ReadLine();
        }
    }
}
