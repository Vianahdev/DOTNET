using System;

namespace ProjectParkinMeter{
    class Program{
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("PROGRAMA PARQUIMETRO");
            Console.WriteLine("---------------------");
            Console.WriteLine("Insira um valor:");

            double v_Valor = double.Parse(Console.ReadLine());
            double v_troco = 0.0;

            if(v_Valor < 1){
                Console.WriteLine("Valor insuficiente");
            }else{
                
                if(v_Valor >= 1  && v_Valor <= 1.75){ 
                    Console.WriteLine($"Tempo: 30 Min");
                }else if(v_Valor > 1.75 && v_Valor < 3){
                    v_troco = v_Valor - 1.75;
                    Console.WriteLine($"Tempo: 60 Min");
                }else{
                    v_troco = v_Valor - 3;
                    Console.WriteLine($"Tempo: 120 Min");  
                }

                Console.WriteLine($"Troco: {v_troco}");
            }    

        }

    }
}