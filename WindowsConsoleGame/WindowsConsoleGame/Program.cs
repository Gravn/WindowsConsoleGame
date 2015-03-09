using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConsoleGame
{
    class Program
    {

        public static Draw d = new Draw();
        

        static void Main(string[] args)
        {
            Console.SetWindowSize(64, 64);
            Console.SetBufferSize(64, 64);
            Console.CursorSize = 100;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();

            GameObject[] objects = new GameObject[10];

            objects[0] = new GameObject(new Vector2(10, 10), ConsoleColor.Green);

            for (int i = 1; i < 10; i++)
            {
                objects[i] = objects[0].Clone();
            }

            Random r = new Random();

            objects[5].pubposition.x = 5;

            foreach (GameObject o in objects)
            {
                o.Draw();
            }

            System.Threading.Thread.Sleep(10);
            
            Console.ReadKey();
        }
    }
}
