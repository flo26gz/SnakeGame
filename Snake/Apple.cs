using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{

    /*This class represents the model of an apple */
    class Apple
    {
        private int x;
        private int y;
        private int sizeX;
        private int sizeY;
        private int type;//1 red apple , 2 gold apple 3 purple apple
     

        /* Getters and setters */
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int SizeY
        {
            get { return sizeY; }
            set { sizeY = value; }
        }

        public int SizeX
        {
            get { return sizeX; }
            set { sizeX = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
