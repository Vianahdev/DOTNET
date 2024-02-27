using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            // PERCORRENDO UM ARRAY UTILIZANDO FOREACH
            Console.Clear();
            
            var myArray = new int[5] {3,34,54,65,32};

            foreach(var item in myArray){   
                Console.WriteLine(item);
            }
        }
    }
}
 