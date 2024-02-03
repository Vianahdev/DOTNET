using System;

namespace CursoCSharp{
    class Program{
        static void Main(String [] args){
            //Simplificando a instancia do product tipo Objeto
            var product = new Product{

                Product_id = 1,
                Product_name = "Teclado Gamer",
                Product_price = 150.45,

            };
            
            Console.WriteLine($"Id do Produto: {product.Product_id}");
            Console.WriteLine($"Nome do Produto: {product.Product_name}");
            Console.WriteLine($"Preço do Produto: {product.Product_price}");
            Console.WriteLine($"Preço do Produto: {product.PriceInDolar(4.97)}");
            
        }

    }

    struct Product{
        public Product(int Product_Id, string Product_Name, double Product_Price){
            Product_Id = Product_id;
            Product_Name = Product_name;
            Product_Price = Product_price;
        }

        public int Product_id {get; set;}
        public string Product_name {get; set;}
        public double Product_price {get; set;}

        public double PriceInDolar (double dolar){
            return Product_price * dolar;
        }

    }
}
 