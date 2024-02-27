using System;

namespace CursoCSharp{
    class Program{
        static void Main(String[] args){
            //INCLUINDO VALORES

            //Podemos utilizar o metodo Add para relaizar modificações nas datas.
           var v_date = DateTime.Now;

           Console.WriteLine(v_date.AddDays(55));
           Console.WriteLine(v_date.AddMonths(55));
           Console.WriteLine(v_date.AddYears(55));
           Console.WriteLine(v_date.AddHours(55));
           Console.WriteLine(v_date.AddMinutes(55));

        }
    }
}
 