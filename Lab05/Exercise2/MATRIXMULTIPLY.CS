
using System;

class MatrixMultiply {
    static void Main() {

        int[,] a = new int[2, 2];
        int[,] b = new int[2, 2];

        Input(a);
        Input(b);

        int [,] result = Multiply(a, b);

        Output(result); 

        //b[0, 0] = int.Parse(Console.ReadLine());
        //b[0, 1] = int.Parse(Console.ReadLine());
        //b[1, 0] = int.Parse(Console.ReadLine());
        //b[1, 1] = int.Parse(Console.ReadLine());

        //int[,] a = { { 1, 2 }, { 3, 4 } };
        //int[,] b = { { 5, 6 }, { 7, 8 } };

        //int[,] result =
        //{
        //        { ((a[0,0]*b[0,0])+(a[0,1]*b[1,0])),  ((a[0,0]*b[0,1]) + (a[0,1]*b[1,1])) },
        //        { ((a[1,0]*b[0,0])+(a[1,1]*b[1,0])),  ((a[1,0]*b[0,1]) + (a[1,1]*b[1,1])) }
        //};

       
    }

    static void Output(int[,] result)
    {
        for (int r = 0; r < result.GetLength(0); r++)
        {
            
            for (int c = 0; c < result.GetLength(1); c++)
            {
                
                Console.Write("{0} ", result[r, c]);
            }
            Console.WriteLine();
        }
        
        //Console.WriteLine(result[0, 0]);
        //Console.WriteLine(result[0, 1]);
        //Console.WriteLine(result[1, 0]);
        //Console.WriteLine(result[1, 1]);
    }

    static int[,] Multiply(int[,]a, int [,]b )
    {
        //int[,] result =
        //{
        //        { ((a[0,0]*b[0,0])+(a[0,1]*b[1,0])),  ((a[0,0]*b[0,1]) + (a[0,1]*b[1,1])) },
        //        { ((a[1,0]*b[0,0])+(a[1,1]*b[1,0])),  ((a[1,0]*b[0,1]) + (a[1,1]*b[1,1])) }
        //};

        int[,] result = new int[2, 2];

        for (int r = 0; r < 2; r++)
        {
            for (int c = 0; c < 2; c++)
            {
                result[r, c] = a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
            }
        }

        return result;
    }

    static void Input(int[,] dst)
    {
        Console.WriteLine("Enter foure integers to fill the body of matrix 2x2: ");

        for (int r = 0; r < 2; r++)
        {
            for (int c = 0; c < 2; c++)
            {
                Console.Write("Enter value for [{0}, {1}] : ", r, c);
                dst[r, c] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();

        //dst[0, 0] = int.Parse(Console.ReadLine());
        //dst[0, 1] = int.Parse(Console.ReadLine());
        //dst[1, 0] = int.Parse(Console.ReadLine());
        //dst[1, 1] = int.Parse(Console.ReadLine());

       

    }
}
    
