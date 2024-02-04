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
        Console.WriteLine("Selecione um valor:");
        int v_operacao = int.Parse(Console.ReadLine());

        Console.WriteLine("-------------------");
        Console.WriteLine("Digite o Primeiro Valor:");
        double v_valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Segundo Valor:");
        double v_valor2 = double.Parse(Console.ReadLine());

        Operacao(v_valor1, v_valor2, v_operacao);
    }    
    static void Operacao(double num1, double num2, int ope){
            switch (ope)
            {
                case 1:
                    Console.WriteLine("-------------------");
                    Console.WriteLine($"O resultado e: {Adicao(num1, num2)}");
                break;

                case 2:
                    Console.WriteLine("-------------------");
                    Console.WriteLine($"O resultado e: {Subtracao(num1, num2)}");
                break;

                case 3:
                    Console.WriteLine("-------------------");
                    Console.WriteLine($"O resultado e: {Multiplicacao(num1, num2)}");
                break;

                case 4:
                    Console.WriteLine("-------------------");
                    Console.WriteLine($"O resultado e: {Divisao(num1, num2)}");
                break;

                default:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Insira um operador valido!!!!");
                break;
            }
    }
    static double Adicao(double num1, double num2){
        return num1 + num2;
    }
    static double Subtracao(double num1, double num2){
        return num1 - num2;
    }
    static double Multiplicacao(double num1, double num2){
        return num1 * num2;
    }
    static double Divisao(double num1, double num2){
        return num1 / num2;
    }
   }    
}