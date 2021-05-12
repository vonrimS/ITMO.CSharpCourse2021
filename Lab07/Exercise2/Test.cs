using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Test
    {

        static void Main()
        {
            

            Console.WriteLine("Below , please type some string to be reversed: ");
            String s1 = Console.ReadLine();

            Utils.Reverse(ref s1);

            Console.WriteLine(s1);

        }

    }
}
