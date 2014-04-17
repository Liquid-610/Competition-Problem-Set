using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Globs
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Dice Outputs:" );
                int[] input = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                int sum = 0;

                

                    for (int g = 0; g <= 2; g++)
                    {
                        int numbers = Convert.ToInt32(input[0]);
                        int numbers1 = Convert.ToInt32(input[1]);
                        int numbers2 = Convert.ToInt32(input[2]);

                      

                        if (input[1] > input[2])
                        {
                            sum = numbers + numbers2;
                            Console.WriteLine("Payoff = ${0}", sum);
                        }
                        

                     
                        
                        if (input[1] == input[2] && input[1] == input[0])
                        {
                            sum = (numbers + numbers1) + numbers2;
                            Console.WriteLine("Payoff = ${0}", sum);
 
                        }

                        if (input[0] > input[2] + input[1] )
                        {
                            Console.WriteLine("Payoff = ${0}", input[0]);
                        }

                        if (input[1] > input[0] + input[2])
                        {
                            Console.WriteLine("Payoff = ${0}", input[1]);
                        }

                        if (input[2] > input[0] + input[1])
                        {
                            Console.WriteLine("Payoff = ${0}", input[2]);
                        }

                       

                    }
                
            
            }

        }
    }
}
