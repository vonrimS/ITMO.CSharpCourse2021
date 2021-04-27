﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Exercise4
{
    class DivideIt
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the first integer");
                string temp = Console.ReadLine();

                int i = Int32.Parse(temp);

                Console.WriteLine("Please enter the second integer");
                temp = Console.ReadLine();

                int j = Int32.Parse(temp);

                int k = i / j;

                Console.WriteLine("The result of dividing {0} by {1} is {2}", i, j, k);

            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }

        }
    }
}

