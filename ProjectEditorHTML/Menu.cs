using System;

namespace ProjectEditorHTML{
    public static class Menu{
        public static void Show(){
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();
        }

        public static void DrawScreen(){

            Colunm(30);

            Console.Write("\n");

            Lines(10, 30);

            Colunm(30);

        }

        public static void WriteOptions(){

        }

        static void Colunm(int numColumns){

            Console.Write("+");
                for(int i = 0; i <= numColumns; i++)
                    Console.Write("-");
            Console.Write("+");
        }

        static void Lines(int numLines, int numColumns){
             for(int lines = 0; lines <= numLines; lines++){
                    Console.Write("|");

                    for(int i = 0; i <= numColumns; i++)
                    Console.Write(" ");

                    Console.Write("|");

                    Console.Write("\n");
                }
        }
    }
}