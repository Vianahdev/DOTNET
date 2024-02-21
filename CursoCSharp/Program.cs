using System;
using System.Text;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            //StringBuilder
            Console.Clear();
            // O Método StringBuilder() e utilizado para agregar uma cadeia muito grande de caracteres.
            // Uitlizamos o metodo Append() para realizar essa agregação.
            
            var text = new StringBuilder(); 
            text.Append("Ola Mundo");
            text.Append(", Este e um teste ");
            text.Append("para podermos, ");
            text.Append("verificar o ");
            text.Append("funcionamento do metodo");

            Console.WriteLine(text);
        }
    }
}
 