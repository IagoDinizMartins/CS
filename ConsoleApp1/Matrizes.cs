using System;

namespace ConsoleApp1 
{
    class Matrizes{ 
        static void Main(string[] args) 
        {
            int[,] array = new int[2,2]{{1,2},{3,4}};

            foreach( int colum in array)
            {
                Console.WriteLine(colum);
            }
        }
    }
}