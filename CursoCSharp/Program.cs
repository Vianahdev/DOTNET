using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            //INTERPOLAÇÃO DE STRING

            var price = 10.2; // Declarando uma variavel do tipo Double

            // Declarando uma variavel do tipo String e realizadno a interpolção para sitring.

            //var text = "O preço do produto é: " + price;
            //var text = string.Format("O preço do produto é {0} , somente na promoção", price);
            var text = $"O preço do produto é {price} , somente na promoção";

            Console.WriteLine(text);
     
        }
    }
}
 