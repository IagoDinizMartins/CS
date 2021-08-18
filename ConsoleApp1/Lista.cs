using System;
using System.Collections.Generic;

namespace ConsoleApp1{ 
    class Lista {
        static void Main(string[] args) {
            List<int> lista = new List<int>();
            
            // adding datas to list
            for ( int i = 0; i < 10; i++)
            {
                lista.Add(i * i);
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine("");

            // removing datas from list
            for(int i = 0; i< lista.Count; i++) {
                if (lista[i] % 2 != 0) {
                    lista.Remove(lista[i]);
                    i -= 1;
                    continue;
                }
                Console.WriteLine(lista[i]);
            }
        }
    }
}