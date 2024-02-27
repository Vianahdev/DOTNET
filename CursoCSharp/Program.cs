using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){

           //FORMATAÇÃO DE DATA

           var v_date = DateTime.Now;
           var v_dateFormat = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", v_date); // Utilizando o Metodo String.Format() para realizara a formatação de uma data

           Console.WriteLine(v_dateFormat);
        }
    }
}
 