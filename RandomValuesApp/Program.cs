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
            int totalRow = GetValue();
            Console.Write("Col: ");
            int totalCol = GetValue();
            int[,] numbers = new int[totalRow, totalCol];
            
            Console.WriteLine("Random Generated Values\n");
            
            Console.Write("{0,-10}","Col");

            for (int col = 0; col < totalCol; col++)
            {
                Console.Write("{0, 6}",col+1);
            }
            Console.WriteLine();
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                Console.Write("Row {0, -6}", row+1);
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    //Gernerate a random number
                    numbers[row, j] = random.Next(1,101);
                    Console.Write("{0, 6}", numbers[row, j]);
                    if (numbers[row, j] > maxValue)
                    {
                        maxValue = numbers[row, j];
                        position = new int[] {row, j};
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nLargest Value: {0}", maxValue);
            Console.WriteLine("Row "+ (position[0]+1));
            Console.WriteLine("Col "+ (position[1]+1));
        }

        public static int GetValue()
        {
            string inval = Console.ReadLine();
            int number;
            if (int.TryParse(inval, out number) && number > 0 && number < 21)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 to 20.");
                return GetValue();
            }
        }
    }
}
