using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] seatingChart = new int[4, 4];

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    seatingChart[i, j] = 1;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(" Seating Chart (1 = available, 0 = booked):");
                PrintSeatingChart(seatingChart);

                Console.Write("\nEnter row number (0 to 3): ");
                if (!int.TryParse(Console.ReadLine(), out int row) || row < 0 || row > 3)
                {
                    Console.WriteLine(" Invalid row number! Press Enter to try again...");
                    Console.ReadLine();
                    continue;
                }

                Console.Write("Enter seat number in the row (0 to 3): ");
                if (!int.TryParse(Console.ReadLine(), out int col) || col < 0 || col > 3)
                {
                    Console.WriteLine(" Invalid seat number! Press Enter to try again...");
                    Console.ReadLine();
                    continue;
                }

                if (seatingChart[row, col] == 1)
                {
                    seatingChart[row, col] = 0; 
                    Console.WriteLine(" Seat booked successfully!");
                }
                else
                {
                    Console.WriteLine(" This seat is already booked. Please choose another one.");
                }

                Console.Write("\nDo you want to book another seat? (yes = y / no = any other key): ");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "y")
                    break;
            }

            Console.WriteLine("\n Thank you for using the seat booking system.");

        }
        static void PrintSeatingChart(int[,] chart)
        {
            for (int i = 0; i < chart.GetLength(0); i++)
            {
                for (int j = 0; j < chart.GetLength(1); j++)
                {
                    Console.Write(chart[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
