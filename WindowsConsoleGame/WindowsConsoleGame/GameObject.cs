using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConsoleGame
{
    class GameObject
    {

        private Vector2 position;

        public Vector2 pubposition
        {
            get {return position; }
            set { position = value; }
        }
        private ConsoleColor color;
        private Draw d;

        public GameObject(Vector2 position,ConsoleColor color)
        {
            this.d = Program.d;
            this.position = position;
            this.color = color;
            
        }

        public void Draw()
        {
            Console.BackgroundColor = color;
            d.Point(position);
        }

        public GameObject Clone()
        {
            GameObject g = (GameObject)this.MemberwiseClone();
            g.pubposition = new Vector2(16, 16);
            return g;
        }



    }
}
