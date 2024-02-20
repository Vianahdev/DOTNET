using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            //EQUALS
            Console.Clear();
            //Metodo Equals() sendo utilizado em uma cadeia de caracteres..
            var text = "Este e um texto de teste";

            Console.WriteLine(text.Equals("Este e um texto de teste"));
            Console.WriteLine(text.Equals("este e um texto de teste", StringComparison.OrdinalIgnoreCase));// Utilizando a função "StringComparison.OrdinalIgnoreCase" para ignorar o case sensitive


            //Metodo Equals() sendo utilizado em um tipo numerico
            var num1 = 30;

            Console.WriteLine(num1.Equals(30));
        }
    }
}
 