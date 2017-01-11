using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class Fibonacci
    {
        public static List<int> FibonacciSequence(int index)
        {
            List<int> sequence = new List<int>();

            //0 & 1 are always in the sequence
            sequence.Add(0);
            sequence.Add(1);

            for (int i = 2; i < index; i++)
            {
                sequence.Add(sequence[i - 2] + sequence[i - 1]);                
            }

            return sequence;
        }

        public static int OneAtDigitAtATime(int index)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < index; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        
    }
}
