using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"The number of values between 1 and 100 that are divisible by 3 with no remainder is: {count}");


        }
    }
}
