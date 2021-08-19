using System;
using System.Collections.Generic;


namespace ConsoleApp1{

    class Dicionario
    {
        static void Main(string[] args) 
        {
            Dictionary<string, string> casais = new Dictionary<string, string>();
            
            casais.Add("Verônica", "Estáquio");
            casais.Add("Susana", "Teseu");
            casais.Add("Felicidade", "Arthur");

            foreach (string keys in casais.Keys) {
                Console.WriteLine(casais[keys]);
            }
        }

    }
}