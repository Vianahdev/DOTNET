﻿using System;

namespace ProjectCaixaEletronico{
    class Program{
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Programa Caixa Eletrônico");
            Console.WriteLine("-------------------");
            Console.WriteLine("Informe o valor do Saque");

            var v_valor = double.Parse(Console.ReadLine());

            var v_Saque = (int)v_valor;

            var v_Nota100 = 0;
            var v_Nota50 = 0;
            var v_Nota10 = 0;

            var v_res = 0;

            if(v_Saque % 10 != 0){

                v_Nota100 = v_Saque/100;
                v_res = v_Saque % 100;

                v_Nota50 = v_res/50;
                v_res = v_res % 50;

                v_Nota10 = v_res/10;

            }

            Console.WriteLine($"Notas de R$ 100: {v_Nota100}");
            Console.WriteLine($"Notas de R$ 50: {v_Nota50}");
            Console.WriteLine($"Notas de R$ 10: {v_Nota10}");
        }

        
    }
}