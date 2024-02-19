using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            //STARTSWITH , ENDWITH
            Console.Clear();
            var text = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine("STARTSWITH"); 
            Console.WriteLine("------------");
            Console.WriteLine(text.StartsWith("Texto"));
            Console.WriteLine(text.StartsWith("texto"));
            Console.WriteLine(text.StartsWith("este"));
            Console.WriteLine(" ");
            Console.WriteLine("ENDWITH");
            Console.WriteLine("------------");
            Console.WriteLine(text.EndsWith("Texto"));
            Console.WriteLine(text.EndsWith("texto"));
            Console.WriteLine(text.EndsWith("metodo"));
        }
    }
}
 