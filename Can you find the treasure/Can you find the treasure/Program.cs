using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Can_you_find_the_treasure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a grid from left to right, top to bottom, in one line: ");
            String input = Console.ReadLine();
            String Start;
            Char[] move = new Char[] { 'u', 'd', 'l', 'r' };
            int x = 0;
            int y = 0;

            char[,] grid = new char[5, 5];

            for (int i = 0; i < input.Length; i++)
            {
                grid[i % 5, i / 5] = input[i];
            }



            while (true)
            {
                
                for (int i = 0; i < move.Length; i++)
                {

                    Start = grid[x, y];

                    if (move[i] == 'r')
                    {
                        x++;
                        
                    }

                    if (move[i] == 'u')
                    {
                        y--;

                    }

                    if (move[i] == 'l')
                    {
                        x = x -1;

                    }

                    if (move[i] == 'd')
                    {
                       y = y + 1;

                    }

                }
            } 
        }
    }
}
