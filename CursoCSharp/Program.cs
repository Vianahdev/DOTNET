using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            // EXCEPTION (TRY/CATCH)
            Console.Clear();            

            try { // Utilizados o Try/Catch para realizar um tratamento de erro em bloco.. 
                Cadastro("");
            }
            catch(IndexOutOfRangeException ex){// Podemos realizar tratamentos de erro para cade problema no codigo
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Indice não encontrado.");
            }
            catch(ArgumentNullException ex){
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Cadastro não realizado.");
            }
            catch (Exception ex){// Podemos utilziar a propriedade Exception para coletar o erro que está ocorrendo.
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ocorreu um erro, informar o administrador.");
            }

        }

        private static void Cadastro(string texto){

            if(string.IsNullOrEmpty(texto))
                throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
        }
    }
}
 