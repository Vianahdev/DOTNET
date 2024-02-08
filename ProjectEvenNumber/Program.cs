using System;

namespace ProjectEvenNumber{
    class Program{
        static void Main(String[] args){
            Menu();
        }

        static void Menu(){

            Console.WriteLine("Veirificar se e impar ou par:");
            Console.WriteLine("-------------------------");
            string v_Number = Console.ReadLine();
                
            Calc(v_Number);
        }   

        static void Calc(string Number){

             if(int.TryParse(Number, out var v_Valor)){
                if(v_Valor % 2 == 0 ){
                    Console.WriteLine("-------------------------");
                    Console.WriteLine($"O numero {v_Valor} e par");
                }else{
                    Console.WriteLine("-------------------------");
                    Console.WriteLine($"O numero {v_Valor} e impar");
                }
            }else{
                Console.WriteLine("-------------------------");
                Console.WriteLine("DIGITE UM VALOR VALIDO!!!");
            }
        }
    }
}