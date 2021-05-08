
using System;                // Console
using System.IO;             // FileStream, FileReader
    
class FileDetails 
{
    static void Main(String [] args) 
	{
        Console.WriteLine(args.Length);

        foreach(string arg in args)
        {
            Console.WriteLine(arg);
        }

        string fileName = args[0];
        
		FileStream stream = new FileStream(fileName, FileMode.Open);
        StreamReader reader = new StreamReader(stream);

        int size = (int)stream.Length;
        char[] contents = new char[size];
        
        for(int i = 0; i< size; i++ )
        {
            contents[i] = (char)reader.Read();
        }

        stream.Close();

        Summarize(contents);

        //foreach (char ch in contents)
        //{
        //    Console.Write(ch);
        //}
    }

    public static void Summarize( char[] contents)
    {
        int vowelCount = 0;
        int consonantCount = 0;
        int newLineCount = 0;
        
        foreach (char current in contents)
        {
            if (Char.IsLetter(current)) {
                if ("AEIOUaeiou".IndexOf(current) != -1)
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }

            }
            else if (current == '\n')
            {
                newLineCount++;
            }
        }

        Console.WriteLine("Total no of characters: {0}", contents.Length);
        Console.WriteLine("Total no of vowels : {0}", vowelCount);
        Console.WriteLine("Total no of consonants: {0}", consonantCount);
        Console.WriteLine("Total no of lines : {0}", newLineCount);

    }
}
