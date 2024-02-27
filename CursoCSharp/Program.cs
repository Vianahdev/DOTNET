using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            // PERCORRENDO UM ARRAY

            var myArray = new int[5] {32, 43, 33, 45, 56};
            
            for(var indice = 0; indice <= myArray.Length; indice++){
                Console.WriteLine(myArray[indice]);
            }
        }
    }
}
 