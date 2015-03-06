using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConsoleGame
{
    class Vector2
    {
        private static double atanZero = Math.Atan2(0, 0);
        public double x, y;

        public Vector2(double px, double py)
        {
            x = px;
            y = py;

        }

        public Vector2 Clone()
        {
            return new Vector2(x, y);
        }

        public void Set(double px, double py)
        {
            x = px;
            y = py;
        }

        public void Copy(Vector2 v)
        {
            x = v.x;
            y = v.y;
        }

        public double Dot(Vector2 v)
        {
            return x * v.x + y * v.y;
        }

        public double Cross(Vector2 v)
        {
            return x * v.y - y * v.x;
        }

        public Vector2 Add(Vector2 v)
        {
            x += v.x;
            y += v.y;
            return this;
        }

        public Vector2 AddNew(Vector2 v)
        {
            return new Vector2(x + v.x, y + v.y);
        }

        public Vector2 Substract(Vector2 v)
        {
            x -= v.x;
            y -= v.y;
            return this;
        }

        public Vector2 SubstractNew(Vector2 v)
        {
            return new Vector2(x - v.x, y - v.y);
        }

        public Vector2 Multiply(double s)
        {
            x *= s;
            y *= s;
            return this;
        }

        public Vector2 MultiplyNew(double s)
        {
            return new Vector2(x * s, y * s);
        }

        public double Distance(Vector2 v)
        {
            double dx = x - v.x;
            double dy = y - v.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public Vector2 Normalize()
        {
            double mag = Math.Sqrt(x * x + y * y);
            x /= mag;
            y /= mag;
            return this;
        }

        public double Magnitude()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public Vector2 Project(Vector2 b)
        {
            double adotb = this.Dot(b);
            double len = (b.x * b.x + b.y * b.y);
            Vector2 proj = new Vector2(0, 0);
            proj.x = (adotb / len) * b.x;
            proj.y = (adotb / len) * b.y;
            return proj;
        }

        public Vector2 Rotate(double angle)
        {
            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);
            return new Vector2(x * cos - y * sin, x * sin + y * cos);
        }

        public double Angle
        {
            get { return Math.Atan2(y, x) - atanZero; }
        }

        public void draw(Vector2 v)
        {
            Draw a = new Draw();
            a.Line(this, v);
        }

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
    }
}
