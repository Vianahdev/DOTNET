using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            // EXCEPTION (TRY/CATCH)
            Console.Clear();

            var myArray = new int[5];
            

            try { // Utilizados o Try/Catch para realizar um tratamento de erro em bloco.. 
                for(var index = 0; index <= 10; index++){
                    Console.WriteLine(myArray[index]);
                }
            }
            catch(IndexOutOfRangeException ex){// Podemos realizar tratamentos de erro para cade problema no codigo
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Indice não encontrado.");
            }
            catch (Exception ex){// Podemos utilziar a propriedade Exception para coletar o erro que está ocorrendo.
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ocorreu um erro, informar o administrador.");
            }

        }
    }
}
 