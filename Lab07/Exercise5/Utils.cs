using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07.Exercise5
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

        public static void Reverse(ref String s)
        {
            String sRev = "";

            for (int i = (s.Length-1); i >= 0; i--)
            {
                sRev += s[i];
            }

            s = sRev;
                           
        }

        public static bool IsItFormattable (object x)
        {
            if (x is System.IFormattable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Display (object item)
        {
            IPrintable ip;

            ip = (item as IPrintable);

            if (ip != null)
            {
                ip.Print();
            }
            else
            {
                Console.WriteLine(item.ToString());
            }

        }

    }
}
