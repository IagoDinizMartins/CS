using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Enumeradores 
    {
        enum Atos { Rezar = 1, Correr, Lutar}
        
        static void Main(string[] args)
        {
            Atos ato1 = Atos.Rezar;
            Atos ato2 = Atos.Lutar;

            Console.WriteLine(ato1);
            Console.WriteLine(ato2);
            Console.WriteLine((int)ato1);
            Console.WriteLine((int)ato2);
        }
    }
}