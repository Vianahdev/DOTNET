﻿using System;

namespace CursoCSharp{
    class Program{
        static void Main(String [] args){
            Console.WriteLine("Informe a tabuada");
            int v_tabuada = int.Parse(Console.ReadLine());

            int i = 0;
            do{
                int v_calc = i * v_tabuada;

                Console.WriteLine($"{v_tabuada} X {i} = {v_calc}");

                i++;
            }while(i <= 10);
        }
    }
}
 