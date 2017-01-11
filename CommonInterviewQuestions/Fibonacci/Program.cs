using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //For OneDigitAtATime
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Fibonacci.OneAtDigitAtATime(i));
            }

            Console.WriteLine("10th number in fibonacci sequence: " + Fibonacci.OneAtDigitAtATime(10));



            Console.ReadLine();
        }
    }
}
