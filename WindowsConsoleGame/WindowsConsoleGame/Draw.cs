using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConsoleGame
{
    class Draw
    {
         public void Point(Vector2 v)
        {
            Point((int)v.x,(int)v.y);
        }

        public void Point(int x,int y)
        {
            if (x > 0 && x < 64 && y > 0 && y < 64)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
            }
        }

        public void Circle(Vector2 v)
        {
            for (float i = 0; i < 360; i+=0.1f)
            {
                Point((int)Math.Sin(i)*16+(int)v.x,(int)Math.Sin(i)*16+(int)v.y);
            }
        }

        public void Line(Vector2 a, Vector2 b)
        {
            Line((int)a.x,(int)a.y,(int)b.x,(int)b.y);
        }

        public void Line(int x0,int y0,int x1,int y1)
        {
            int dx = Math.Abs(x0 - x1);
            int dy = Math.Abs(y0 - y1);
            bool steep = dy > dx;
            if (steep)
            {
                int temp = x0;
                x0 = y0;
                y0 = temp;

                temp = x1;
                x1 = y1;
                y1 = temp;
            }
            int x = x0;
            int y = y0;
            dx = Math.Abs(x0 - x1);
            dy = Math.Abs(y0 - y1);
            int error = 0;

            int l = dx > dy ? dx : dy;

            while(x != x1)
            {
                x += x0 < x1 ? 1 : -1;
                error += dy;
                if (error > dx)
                { 
                    y += y0 < y1 ? 1:-1;
                    error -= dx;
                }

                if (steep)
                {
                    Point(y, x);
                }
                else
                {
                    Point(x, y);
                }
            }
        }
    }
}
