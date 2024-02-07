using System;

namespace ProjectCaixaEletronico{
    class Program{
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Programa Caixa Eletrônico");
            Console.WriteLine("-------------------");
            Console.WriteLine("Não utilizar o '.' e sim ','");
            Console.WriteLine("-------------------");
            Console.WriteLine("Informe o valor do Saque");

            var v_Saque = double.Parse(Console.ReadLine()); 

            var v_Nota100 = 0.0;
            var v_Nota50 = 0.0;
            var v_Nota10 = 0.0;

            var v_res = 0.0;

            if(v_Saque % 10 == 0){

                v_Nota100 = Math.Floor(v_Saque/100);
                v_res = v_Saque % 100;

                v_Nota50 = Math.Floor(v_res/50);
                v_res = v_res % 50;

                v_Nota10 = Math.Floor(v_res/10);

                Console.WriteLine($"Notas de R$ 100: {v_Nota100}");
                Console.WriteLine($"Notas de R$ 50: {v_Nota50}");
                Console.WriteLine($"Notas de R$ 10: {v_Nota10}");

            }else{
                Console.WriteLine("O caixa não possui o valor digitado...");
            }

            
        }

        
    }
}