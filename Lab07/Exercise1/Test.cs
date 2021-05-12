using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07.Exercise1
{
    public class Test
    {
        public static void Main()
        {
            BankAccount a = new BankAccount();
            a.Populate(100);

            BankAccount b = new BankAccount();
            b.Populate(100);

            a.GetInfo();
            b.GetInfo();

            Console.WriteLine("...$10 was transfered between accounts");
            a.TransferFrom(b, 10);

            a.GetInfo();
            b.GetInfo();

        }



    }
}
