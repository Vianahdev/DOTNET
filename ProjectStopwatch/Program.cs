using System; 
using System.Threading;

namespace ProjectStopwatch{
    class Program{
        static void Main(String[] args){
            Start();
        }

        static void Start(){
            int v_time = 10;
            int v_currentTime = 0;

            while(v_currentTime != v_time){
                Console.Clear();
                v_currentTime++;
                Console.WriteLine($"{v_currentTime}");
                Thread.Sleep(1000);
            }
        }
    }
}