using System;

namespace CursoCSharp{
    class Program{
        static void Main(String [] args){
           int v_valor = 0;

           switch (v_valor){

            case 1: Console.WriteLine($"Olá Mundo o valor é: {v_valor}");
            break;

            case 2: Console.WriteLine($"Olá o valor é: {v_valor}");
            break;

            case 3: Console.WriteLine($"Olá Mundo, é: {v_valor}");
            break;

            default: Console.WriteLine("Olá Mundo o valor é: Null");
            break;
           }
        }
    }
}
 