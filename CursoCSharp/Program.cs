using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            //METODOS ADICIONAIS

            var text = "Este E um TEXTO de teSTe";

            Console.WriteLine(text.ToUpper()); // O metodo ToUpper() e utilizado para conversão da string para MAIUSCULO
            Console.WriteLine(text.ToLower()); // O metodo ToLower() e utilizado para conversão da string para minusculo
            Console.WriteLine(text.Insert(9," ..OLA")); // O metodo Insert() e utilizado para inserir um novo objeto.
            Console.WriteLine(text.Remove(9,0)); // O metodo Remove() e utilizado para remove algum objeto.
            Console.WriteLine(text.Length); // O metodo Length e utilziado para verificar o tamanho da cadeia de caractere.
        }
    }
}
 