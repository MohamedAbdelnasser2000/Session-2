using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" x\t y\t z\t x && y && z\t x || y || z");
            Console.WriteLine("-------------------------------------------------------");

            bool[] values = { false, true };

            foreach (bool x in values)
            {
                foreach (bool y in values)
                {
                    foreach (bool z in values)
                    {
                        bool andResult = x && y && z;
                        bool orResult = x || y || z;

                        Console.WriteLine($"{x}\t {y}\t {z}\t {andResult}\t\t {orResult}");
                    }
                }
            }

        }
    }
}
