using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            //INDEX
            
            var text = "Este e um texto de teste";

            Console.WriteLine(text.IndexOf("teste"));// O metodo IndexOf() verificar a posição de determinado caractere
            Console.WriteLine(text.LastIndexOf("e"));// O metodo LastIndexOf() verifica a ultima posição de um determinado caractere
        }
    }
}
 