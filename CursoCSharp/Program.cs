﻿using System;
using System.Diagnostics.Contracts;

namespace CursoCSharp{
    class Program{
        static void Main(String [] args){
            int v_tabuada = 2;

            for (int i = 0; i <= 10; i++){
                    int v_calc = i * v_tabuada;

                    Console.WriteLine($"{v_tabuada} X {i} = {v_calc}");
            };
        }
    }
}
 