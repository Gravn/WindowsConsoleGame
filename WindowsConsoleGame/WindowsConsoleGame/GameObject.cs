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

        public Vector2 Position
        {
            get {return position; }
            set { position = value; }
        }

        private Vector2 velocity = new Vector2(0,0);

        public Vector2 Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }
        private ConsoleColor color;

        public ConsoleColor Color
        {
            get { return color; }
            set { color = value; }
        }

        private Draw d;

        public GameObject(Vector2 position,ConsoleColor color)
        {
            this.d = GameWorld.d;
            this.position = position;
            this.color = color;
        }

        public void Update(float spf)
        {
            if(velocity.y <=30)
            {
                velocity += GameWorld.gravity;
            }

            if (position.y >= 60)
            {
                velocity = new Vector2(1,0);
            }

            position += velocity * spf;
        }

        public void Draw()
        {
            Console.BackgroundColor = color;
            d.Point(position);
        }

        public GameObject Clone()
        {
            GameObject g = (GameObject)this.MemberwiseClone();
            g.Position = new Vector2(32, 32);
            return g;
        }



    }
}
