using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DivisionBySubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 13;
            int b = 4;
            int[] temp = new int[] { };

            temp = division(a, b);
            Console.WriteLine($"{a} divided by {b} is {temp[0]} r {temp[1]}");
            
            Console.ReadKey();
        }

        static int[] division(int x, int y)
        {
            int count = 0;
            int[] temp = new int[2];

            if(x >= y)
            {
                // do the thing
                x = x - y;
                count = 1;
                temp = division(x, y);
                count = count + temp[0];
                x = temp[1];
            }

            // return the thing
            return new int[] { count, x};
        }
    }
}
