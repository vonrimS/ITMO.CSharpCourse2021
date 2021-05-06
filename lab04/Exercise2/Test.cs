using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.Exercise2
{
    class Test
    {

        static void Main(string[] args)
        {
            int x, y, greater;

            Console.WriteLine("Enter the first argument...");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second argument...");
            y = int.Parse(Console.ReadLine());

            greater = Utils.Greater(x, y);

            Console.WriteLine("According to your input, the greatest value is {0}", greater);

            Utils.Swap(ref x, ref y);

        }

    }
}
