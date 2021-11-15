using System;

namespace RandomValuesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Row: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Col: ");
            int col = int.Parse(Console.ReadLine());
            int[,] numbers = new int[row, col];

            Console.WriteLine("Random Generated Values\n");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    //Gernerate a random number
                    


                    if (j==0)
                    {
                        Console.WriteLine(String.Format("Row {0,-8}", i));
                    }
                }
            }
        }
    }
}
