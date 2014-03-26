using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LETS_START
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("Dice: ");
                int[] input = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                Array.Sort(input);
                    
                Console.Write("Payoff: ");
                int payoff = input[0];
                int sum = input[0];

                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i] == input[i - 1])
                        sum += input[i];
                    else
                    {
                        sum = input[i];
                    }

                    if (sum > payoff)
                        payoff = sum;
                }

                Console.WriteLine(payoff);
        }
    }
}
