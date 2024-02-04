using System;

namespace ProjectCalculator{
   class Program{
        static void Main(String[] args){
            Menu();
        }

    static void Menu(){
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - SOMA");
        Console.WriteLine("2 - SUBTRAÇÃO");
        Console.WriteLine("3 - MULTIPLICAÇÃO");
        Console.WriteLine("4 - DIVISÃO");

        Console.WriteLine("-------------------");
        Console.WriteLine("Selecione uma opção: ");
        short v_ope = short.Parse(Console.ReadLine());

        
        switch (v_ope)
        {
            case 1: Adicao(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            default: Console.WriteLine("Favor insira um valor valido"); Menu(); break;
        }

        
    }



    static void Adicao(){

        Console.WriteLine("-------------------");
        Console.WriteLine("Digite o Primeiro Valor:");
        double v_valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Segundo Valor:");
        double v_valor2 = double.Parse(Console.ReadLine());

        double v_res = v_valor1 + v_valor2;
        Console.WriteLine($"O resultado da Adição é: {v_res}");
        Console.ReadKey();

    }
    static void Subtracao(){

        Console.WriteLine("-------------------");
        Console.WriteLine("Digite o Primeiro Valor:");
        double v_valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Segundo Valor:");
        double v_valor2 = double.Parse(Console.ReadLine());

        double v_res = v_valor1 - v_valor2;
        Console.WriteLine($"O resultado da Subtração é: {v_res}");
        Console.ReadKey();
    }
    static void Multiplicacao(){

        Console.WriteLine("-------------------");
        Console.WriteLine("Digite o Primeiro Valor:");
        double v_valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Segundo Valor:");
        double v_valor2 = double.Parse(Console.ReadLine());

        double v_res = v_valor1 * v_valor2;
        Console.WriteLine($"O resultado da Multiplicação é: {v_res}");
        Console.ReadKey();
    }
    static void Divisao(){

        Console.WriteLine("-------------------");
        Console.WriteLine("Digite o Primeiro Valor:");
        double v_valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Segundo Valor:");
        double v_valor2 = double.Parse(Console.ReadLine());

        double v_res = v_valor1 / v_valor2;
        Console.WriteLine($"O resultado da Divisão é: {v_res}");
        Console.ReadKey();
    }
   }    
}