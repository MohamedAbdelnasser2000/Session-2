using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a series of numbers separated by commas: ");
            string input = Console.ReadLine();

            int[] numbers;
            try
            {
                numbers = input.Split(',')
                               .Select(n => int.Parse(n.Trim()))
                               .ToArray();
            }
            catch
            {
                Console.WriteLine(" Invalid input! Please enter only numbers separated by commas.");
                return;
            }

            int max = numbers.Max();

            Console.WriteLine($"The maximum number is: {max}");



        }
    }
}
