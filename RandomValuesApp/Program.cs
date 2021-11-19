using System;
using System.Data;

namespace RandomValuesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxValue = 0;
            int[] position = new int[2];
            
            Console.Write("Row: ");
            int totalRow = GetValidNumber(1,20);
            Console.Write("Col: ");
            int totalCol = GetValidNumber(1,20);
            int[,] numbers = new int[totalRow, totalCol];
            
            Console.WriteLine("Random Generated Values\n");
            
            Console.Write("{0,-10}","Col");
            
            //Print column numbers.
            for (int col = 0; col < totalCol; col++)
            {
                Console.Write("{0, 6}",col+1);
            }
            Console.WriteLine();
            
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                //Print row numbers.
                Console.Write("Row {0, -6}", row+1);
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    //Generate a random number from 1 to 100.
                    numbers[row, col] = random.Next(1,101);
                    //Print cell's value.
                    Console.Write("{0, 6}", numbers[row, col]);
                    if (numbers[row, col] > maxValue)
                    {
                        //Record new maximum value.
                        maxValue = numbers[row, col];
                        //Record new position.
                        position = new int[] {row, col};
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nLargest Value: {0}", maxValue);
            Console.WriteLine("Row "+ (position[0]+1));
            Console.WriteLine("Col "+ (position[1]+1));
        }

        public static int GetValidNumber(int min, int max)
        {
            if (int.TryParse(Console.ReadLine(), out int result) && result >= min && result <= max)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Please enter a number between {0} to {1}.", min, max);
                return GetValidNumber(min, max);
            }
        }
    }
}
