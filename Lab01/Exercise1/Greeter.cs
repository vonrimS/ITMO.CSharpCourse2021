using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Greeter
    {
        static void Main(string[] args)
        {
            string myName;

            Console.WriteLine("Enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Your name is {0}!", myName);
        }
    }
}
