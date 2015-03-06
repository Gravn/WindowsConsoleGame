using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(64, 64);
            Console.SetBufferSize(64, 64);
            Console.CursorSize = 100;



            Draw d = new Draw();
            Vector2 a = new Vector2(16, 16);
            Vector2 b = new Vector2(48, 48);
            double anglea =0;
            double angleb = 3.14f;

            while (true)
            { 
                if(anglea>Math.PI)
                {
                    anglea-=2*Math.PI;
                }

                anglea+=0.1f;

                if (angleb >Math.PI)
                {
                    angleb -=2*Math.PI;
                }

                angleb += 0.1f;

                Console.BackgroundColor = ConsoleColor.Black;
                d.Line(a, b);


                a.x = Math.Sin(anglea) * 16 + 32;
                a.y = Math.Cos(anglea) * 16 + 32;

                b.x = Math.Sin(angleb) * 16 + 32;
                b.y = Math.Cos(angleb) * 16 + 32;

                Console.BackgroundColor = ConsoleColor.White;
                d.Line(a, b);

                System.Threading.Thread.Sleep(10);
            }
            


            Console.ReadKey();
        }
    }
}
