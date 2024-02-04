using System;

namespace CursoCSharp{
    class Program{
        static void Main(String [] args){
            
            var cliente = new Cliente{
                Cliente_name = "Matheus",
                Cliente_idade = 24,
                EstadoCivil = EEstadoCivil.Solteiro
            };

        
            Console.WriteLine($"Nome Cliente: {cliente.Cliente_name}");
            Console.WriteLine($"Idade Cliente: {cliente.Cliente_idade}");
            Console.WriteLine($"Estado Civil: {cliente.EstadoCivil}");
        }

    }

    struct Cliente{
        public string Cliente_name;
        public int Cliente_idade;
        public EEstadoCivil EstadoCivil;
        
    }

    enum EEstadoCivil{
        Solteiro = 1,
        Casado = 2,
        Divorciado = 3,
    }
}
 