using System;

namespace CursoCSharp{
    class Program{
        static void Main(String [] args){
            var v_firstName = "";
            var v_lastName = "";

            Console.WriteLine("Qual seu Primeiro Nome:");
            v_firstName = Console.ReadLine();

            Console.WriteLine("Qual seu ultimo Nome:");
            v_lastName = Console.ReadLine();


            Console.WriteLine(ReturnName(v_firstName, v_lastName));
        }

        static String ReturnName( string firstName, string LastName){
            return "Seu Nome é:" + firstName + ", e seu ultimo nome é:" + LastName; 
        }
    }
}
 