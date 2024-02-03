using System;

namespace CursoCSharp{
    class Program{
        static void Main(String [] args){
            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;

            Console.WriteLine($"Variavel {arr[0]}");
            Console.WriteLine($"Variavel {arr2[0]}");

            arr[0] = "Item 2";

            Console.WriteLine($"Variavel {arr[0]}");
            Console.WriteLine($"Variavel {arr2[0]}");
        }

    }
}
 