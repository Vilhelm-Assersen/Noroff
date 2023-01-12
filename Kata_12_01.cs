using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_development
{
    internal class Kata_12_01
    {
        public static void kata_12_01()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
                if ((i % 5) == 0 && (i % 3) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                
            }
            Console.ReadLine();
        }


    }
}
