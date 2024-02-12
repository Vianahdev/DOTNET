using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){      
            var id = Guid.NewGuid(); // Guid - Global Unique Identifier (Identificaor unico universal) gera um hash unico.

            id.ToString(); // Tranformando o valor do Guid em uma string

            id = new Guid("39ebb384-103f-4a60-83ff-08069b9545e9"); // Setando um valor guid especifico na variaval id.

            Console.WriteLine(id.ToString().Substring(0, 8)); // Utilizando o função Substring para encurtar o hash gerado pelo guid
     
        }
    }
}
 