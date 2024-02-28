using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            // EXCEPTION (TRY/CATCH)
            Console.Clear();

            var myArray = new int[5];

            try {
                for(var index = 0; index <= 10; index++){
                    Console.WriteLine(myArray[index]);
                }
            }
            catch (Exception ex){
                /* Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message); */
                Console.WriteLine("Ocorreu um erro, informar o administrador.");
            }

        }
    }
}
 