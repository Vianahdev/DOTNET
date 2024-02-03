using System;

namespace CursoCSharp{
    class Program{
        static void Main(String [] args){
            int x = 25;
            int y = x;

            Console.WriteLine($"Variavel {x}");
            Console.WriteLine($"Variavel {y}");

            x = 32;

            Console.WriteLine($"Variavel {x}");
            Console.WriteLine($"Variavel {y}");
        }

    }
}
 