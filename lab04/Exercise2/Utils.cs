using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.Exercise2
{
    class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;

        }

        public static void Swap(ref int a, ref int b)
        {
            int temp;
            Console.WriteLine("BEFORE swapping we got values a = {0} and b = {1}", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("...and AFTER swapping we got values a = {0} and b = {1}", a, b);
        }
    }
}
