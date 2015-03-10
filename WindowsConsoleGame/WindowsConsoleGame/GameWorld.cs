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
        public GameObject[] objects = new GameObject[10];
        public Random r = new Random();

        public GameWorld()
        { 
                
        }

        public void Update()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            foreach (GameObject o in objects)
            {
                o.Draw();
                //o.Position.x +=r.Next(-1,2);
                //o.Position.y += r.Next(-1, 2);
            }

            Update();
        }

        public void Setup()
        {
            Console.SetWindowSize(64, 64);
            Console.SetBufferSize(64, 64);
            Console.CursorSize = 100;
            

            objects[0] = new GameObject(new Vector2(32, 32), ConsoleColor.Green);

            for (int i = 1; i < 10; i++)
            {
                objects[i] = objects[0].Clone();

            }

            objects[5].Position.x = 32;
            objects[5].Color = ConsoleColor.Blue;
            Update();
        }
        

    }
}
