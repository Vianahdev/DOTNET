using System; 
using System.Threading;

namespace ProjectStopwatch{
    class Program{
        static void Main(String[] args){

            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("S - Segundo -> 10S -> 10 Segundos");
            Console.WriteLine("M - Minuto -> 10M -> 10 Minutos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0,data.Length - 1));

            int multplier = 1;

            if(type == 'm')
                multplier = 60;
            
            if(time == 0)
                System.Environment.Exit(0);

            PreStart(time * multplier);

            
        }

        static void PreStart(int time){
            Console.Clear();
            Console.WriteLine("Read...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO!!!...");
            Thread.Sleep(2000);

            Start(time);
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