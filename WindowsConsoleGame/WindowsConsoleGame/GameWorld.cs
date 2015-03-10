using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConsoleGame
{
    class GameWorld
    {
        public static Draw d = new Draw();
        public GameObject[] objects = new GameObject[1];
        public Random r = new Random();
        public static Vector2 gravity = new Vector2(0,9.82f);
        public DateTime endtime;
        public float spf;
        



        public GameWorld()
        { 
                
        }

        public void Update()
        {
            DateTime startTime = DateTime.Now;
            TimeSpan DeltaTime = startTime - endtime;
            int milliseconds = DeltaTime.Milliseconds > 0 ? DeltaTime.Milliseconds : 1;
            spf = 1 / (1000 / (float)milliseconds);
            endtime = DateTime.Now;

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            foreach (GameObject o in objects)
            {
                o.Update(spf);
                o.Draw();
            }
            Debug();
            //System.Threading.Thread.Sleep(20);
            
            Update();


        }

        public void Debug()
        {
            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(spf);   
        }

        public void Setup()
        {
            Console.SetWindowSize(64, 64);
            Console.SetBufferSize(64, 64);
            Console.CursorSize = 100;
            
            objects[0] = new GameObject(new Vector2(32, 32), ConsoleColor.Green);

            for (int i = 1; i < 10; i++)
            {
                //objects[i] = objects[0].Clone();
            }
            //objects[5].Position.x = 32;
            //objects[5].Color = ConsoleColor.Blue;
            Update();
        }
    }
}
