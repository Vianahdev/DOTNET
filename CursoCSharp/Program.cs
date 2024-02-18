using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            //COMPARAÇÃO DE STRING
            Console.Clear();
            var texto = Console.ReadLine();

             
            // UTILIZANDO O METEDO COMPARETO()
            if(texto.CompareTo("teste") == 0) // Utilizando o metodo CompareTo() para realizar a comparação de uma string.
                Console.WriteLine("Contem a palavra teste");

            else
                Console.WriteLine("Não contem a palavra teste");
            

            //UTILIZANDO O METODO CONTAINS()
            if(texto.Contains("teste") == true) // Utilizando o metodo Contains() para realizar a comparação de um pedaço de texto ou uma string.
                Console.WriteLine("O texto contem a palavra teste");

            else
                Console.WriteLine("O texto não contem a palavra teste");
        }
    }
}
 