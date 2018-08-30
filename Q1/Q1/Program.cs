using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------- this program can tell you if your number is even or odd ------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Pease enter a whole number between 1 and 1000");
            int num1 = int.Parse(Console.ReadLine());

            if ( num1%2 == 0)
            {
                Console.WriteLine("the number you entered is even");
            }
            else
            {
                Console.WriteLine("you entered an uneven number");
            }
            Console.ReadLine();
        }
    }
}
