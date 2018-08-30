using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------- this program will find the average of 10 numbers ---------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            /*

            int j = 1;
            
            while (j <= 10)
            {
               
                Console.WriteLine("Enter number {0}",j);
                int total = int.Parse(Console.ReadLine());
                j++;
                Console.WriteLine(total);

            }


            tried the loop, think I was close but couldn't get there had to use the easy way


            */
            
            Console.WriteLine("please type 10 After each number press enter");
            Console.WriteLine("Enter number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 4");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 5");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 6");
            int num6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 7");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 8");
            int num8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 9");
            int num9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 10");
            int num10 = int.Parse(Console.ReadLine());
            decimal total = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
            Console.WriteLine("the average of the ten numbers is: {0}", total / 10);




            Console.ReadLine();
        }
    }
}
