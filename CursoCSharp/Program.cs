using System;
using System.ComponentModel;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            // PERCORRENDO UM ARRAY UTILIZANDO FOREACH
            Console.Clear();
            
            var myFuncionarios = new Funcionarios[2];

            myFuncionarios[0] = new Funcionarios() {Id=2234 , Name="Matheus", Cargo=CargoFunc.Presidente};
            myFuncionarios[1] = new Funcionarios() {Id=3422 , Name="Gabriel", Cargo=CargoFunc.Gerente};

            foreach( var pessoa in myFuncionarios){
                Console.WriteLine($"Id:{pessoa.Id} Name:{pessoa.Name} Cargo:{pessoa.Cargo} \n");
            }
        }

        public struct Funcionarios{
            public int Id {get; set;}
            public string Name {get; set;}
            public CargoFunc Cargo;
        }

        public enum CargoFunc{
            Presidente = 1,
            Sócio = 2,
            Gerente = 3,
            Analista  = 4, 
        }
    }
}
 