using System;

namespace CursoCSharp{
    class Program{
        static void Main(String [] args){
            var product = new Product();


            product.Id = 1;
            product.Name_Product = "Teclado Gamer";
            product.Price_Product = 150.45f;
            
            
            Console.WriteLine($"Id do Produto: {product.Id}");
            Console.WriteLine($"Nome do Produto: {product.Name_Product}");
            Console.WriteLine($"Preço do Produto: {product.Price_Product}");
            Console.WriteLine($"Preço do Produto: {product.PriceInDolar(4.97f)}");
            
        }

    }

    struct Product{
        public int Id;
        public string Name_Product;
        public float Price_Product;

        public float PriceInDolar (float dolar){
            return Price_Product * dolar;
        }

    }
}
 