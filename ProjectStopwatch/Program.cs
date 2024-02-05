using System; 
using System.Threading;

namespace ProjectStopwatch{
    class Program{
        static void Main(String[] args){

            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("S - Segundo");
            Console.WriteLine("M - Minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1, 1));
            int time = int.Parse(data.Substring(0,data.Length-1));

            Console.WriteLine(data);
            Console.WriteLine(type);
            Console.WriteLine(time);

        }

        static void Start(int time){
            
            int v_currentTime = 0;

            while(v_currentTime != time){
                Console.Clear();
                v_currentTime++;
                Console.WriteLine($"{v_currentTime}");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!!");
            Thread.Sleep(2500);
        }
    }
}