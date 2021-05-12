    using System;
    using System.IO;

/// <summary>
///    Class to create an upper case copy of a file
/// </summary>
/// 
namespace Lab07

{
    public class CopyFileUpper
    {
        public static void Main()
        {
            string sFrom, sTo;

            StreamReader srFrom;

            StreamWriter swTo;

            Console.WriteLine("Enter path/name of input file: ");
            sFrom = Console.ReadLine();

            Console.WriteLine("Enter path/name of output file: ");
            sTo = Console.ReadLine();

            try
            {
                srFrom = new StreamReader(sFrom);
                swTo = new StreamWriter(sTo);
                string sBuffer = "";

                while (srFrom.Peek() != -1)
                {
                    sBuffer = srFrom.ReadLine().ToUpper();
                    swTo.WriteLine(sBuffer);
                }
                swTo.Close();
                srFrom.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("...file was't found, check the name");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("...some stuff goes wrong and we have no qlue what exactly");
                Console.WriteLine(e.Message);
            }
        }
    }
}

