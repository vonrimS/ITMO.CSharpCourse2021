using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07.Exercise4
{
    class Test
    {

        static void Main()
        {
            int i = 0;
            ulong ul = 0;
            string s = "";

            Console.WriteLine("int: {0}", Utils.IsItFormattable(i));
            Console.WriteLine("ulong: {0}", Utils.IsItFormattable(ul));
            Console.WriteLine("string: {0}", Utils.IsItFormattable(s));

        }
    }
}
