using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number to calculate its factorial: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                long factorial = 1;

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($"{number}! = {factorial}");
            }
            else
            {
                Console.WriteLine(" Invalid input! Please enter a non-negative integer.");
            }

        }
    }
}
