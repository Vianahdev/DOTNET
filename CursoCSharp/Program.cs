using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            //MANIPULANDO STRING

            var text = " Este E um TEXTO de teSTe ";

            Console.WriteLine(text.Replace("Este", "Ola,"));// O método Replace() e utilizado para substituir um objeto por outro.

            var div = text.Split(" ");// O método Split() e utilizado para realizar uma divição dentro de uma cadeia, muito utilziado em lista.
            Console.WriteLine(div[0]);
            Console.WriteLine(div[1]);
            Console.WriteLine(div[2]);
            Console.WriteLine(div[3]);
            Console.WriteLine(div[4]);

            var result = text.Substring(6,10);// O método Substring() e utilizado para podermos coletar uma determinada cadeia de caractere.
            Console.WriteLine(result);

            Console.WriteLine(text.Trim());// O método Trim() e utilizado para remover os espaçamentos do inicio e final da cadeia de caractere.
        }
    }
}
 